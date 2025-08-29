using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;

namespace FoodDeliveryAna.Web.Services
{
    public class PixabayService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMemoryCache _cache;
        private readonly string _apiKey;
        private static readonly JsonSerializerOptions _jsonOpts = new(JsonSerializerDefaults.Web);

        public PixabayService(IHttpClientFactory httpClientFactory, IConfiguration configuration, IMemoryCache cache)
        {
            _httpClientFactory = httpClientFactory;
            _cache = cache;
            _apiKey = configuration["Pixabay:ApiKey"] ?? string.Empty;
        }

        private sealed class PixabayResponse { public List<PixabayHit>? hits { get; set; } }
        private sealed class PixabayHit
        {
            public string? webformatURL { get; set; }   // ~640px (fast for cards)
            public string? largeImageURL { get; set; }
            public string? previewURL { get; set; }
        }

        // ---------- FOOD (menu items) ----------
        public Task<string> GetImageUrlAsync(string name, bool small = true)
        {
            var key = $"px:food:{small}:{(name ?? string.Empty).Trim().ToLowerInvariant()}";

            return _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(6);

                var client = _httpClientFactory.CreateClient("pixabay");
                var queries = BuildFoodQueries(name);

                foreach (var q in queries)
                {
                    var url = await TryFetchOneAsync(client, q, editorsChoice: true, small, seed: name ?? "", category: "food");
                    if (url != null) return url;

                    url = await TryFetchOneAsync(client, q, editorsChoice: false, small, seed: name ?? "", category: "food");
                    if (url != null) return url;
                }

                // Generic food safety net (API-only)
                foreach (var q in new[] { "food", "restaurant meal", "gourmet food", "delicious meal" })
                {
                    var url = await TryFetchOneAsync(client, q, true, small, seed: name ?? "", category: "food");
                    if (url != null) return url;

                    url = await TryFetchOneAsync(client, q, false, small, seed: name ?? "", category: "food");
                    if (url != null) return url;
                }

                return $"https://pixabay.com/api/?key={_apiKey}&q=food&category=food&image_type=photo&orientation=horizontal&per_page=30&safesearch=true&order=popular&editors_choice=true";
            })!;
        }

        // ---------- RESTAURANTS (interior/exterior) ----------
        public Task<string> GetRestaurantImageUrlAsync(string name, bool small = true)
        {
            var key = $"px:rest:{small}:{(name ?? string.Empty).Trim().ToLowerInvariant()}";

            return _cache.GetOrCreateAsync(key, async entry =>
            {
                entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(12);

                var client = _httpClientFactory.CreateClient("pixabay");
                var queries = BuildRestaurantQueries(name);

                foreach (var q in queries)
                {
                    // No category=food here — we want interiors/exteriors/facades.
                    var url = await TryFetchOneAsync(client, q, true, small, seed: name ?? "", category: null);
                    if (url != null) return url;

                    url = await TryFetchOneAsync(client, q, false, small, seed: name ?? "", category: null);
                    if (url != null) return url;
                }

                // Generic restaurant safety net
                foreach (var q in new[] { "restaurant interior", "restaurant exterior", "restaurant facade", "restaurant dining room" })
                {
                    var url = await TryFetchOneAsync(client, q, true, small, seed: name ?? "", category: null);
                    if (url != null) return url;

                    url = await TryFetchOneAsync(client, q, false, small, seed: name ?? "", category: null);
                    if (url != null) return url;
                }

                return $"https://pixabay.com/api/?key={_apiKey}&q=restaurant%20interior&image_type=photo&orientation=horizontal&per_page=30&safesearch=true&order=popular&editors_choice=true";
            })!;
        }

        // ---------- Query builders ----------
        private static IEnumerable<string> BuildFoodQueries(string name)
        {
            var lower = (name ?? "").Trim().ToLowerInvariant();
            var list = new List<string>();
            if (!string.IsNullOrWhiteSpace(lower))
            {
                list.Add(lower);
                list.Add($"{lower} food");
            }

            if (lower.Contains("soup"))
                list.AddRange(new[] { "soup bowl", "hot soup", "seafood soup", "vegetable soup" });
            if (lower.Contains("fish") || lower.Contains("trout") || lower.Contains("salmon") || lower.Contains("tuna"))
                list.AddRange(new[] { "seafood dish", "grilled fish", "seafood plate" });
            if (lower.Contains("pasta") || lower.Contains("spaghetti") || lower.Contains("penne") || lower.Contains("carbonara"))
                list.AddRange(new[] { "italian pasta", "pasta plate" });
            if (lower.Contains("salad") || lower.Contains("caesar"))
                list.AddRange(new[] { "fresh salad", "caesar salad" });
            if (lower.Contains("burger"))
                list.AddRange(new[] { "burger", "cheeseburger" });
            if (lower.Contains("pizza"))
                list.AddRange(new[] { "pizza", "pizza slice", "italian pizza" });
            if (lower.Contains("sushi") || lower.Contains("maki") || lower.Contains("nigiri"))
                list.AddRange(new[] { "sushi platter", "japanese food" });
            if (lower.Contains("steak") || lower.Contains("beef"))
                list.AddRange(new[] { "grilled steak", "beef steak" });
            if (lower.Contains("dessert") || lower.Contains("cake") || lower.Contains("tiramisu") || lower.Contains("ice"))
                list.AddRange(new[] { "dessert", "cake", "tiramisu dessert", "ice cream dessert" });

            list.AddRange(new[] { "restaurant meal", "gourmet food", "delicious meal" });
            return DistinctClean(list);
        }

        private static IEnumerable<string> BuildRestaurantQueries(string name)
        {
            var lower = (name ?? "").Trim().ToLowerInvariant();
            var list = new List<string>();

            if (!string.IsNullOrWhiteSpace(lower))
            {
                list.Add($"{lower} restaurant");
                list.Add($"{lower} restaurant exterior");
                list.Add($"{lower} restaurant interior");
                list.Add($"{lower} bistro");
                list.Add($"{lower} cafe");
            }

            list.AddRange(new[]
            {
                "restaurant interior", "restaurant exterior", "restaurant facade",
                "restaurant dining room", "bistro interior", "cafe exterior",
                "restaurant sign", "table setting restaurant"
            });

            return DistinctClean(list);
        }

        private static IEnumerable<string> DistinctClean(IEnumerable<string> inputs) =>
            inputs.Where(q => !string.IsNullOrWhiteSpace(q))
                  .Select(q => q.Trim())
                  .Distinct(StringComparer.OrdinalIgnoreCase);

        // ---------- Fetch one result with optional category ----------
        private async Task<string?> TryFetchOneAsync(HttpClient client, string q, bool editorsChoice, bool small, string seed, string? category)
        {
            var url = $"?key={_apiKey}" +
                      $"&q={Uri.EscapeDataString(q)}" +
                      (string.IsNullOrWhiteSpace(category) ? "" : $"&category={category}") +
                      $"&image_type=photo&orientation=horizontal" +
                      $"&per_page=30&safesearch=true&order=popular" +
                      (editorsChoice ? "&editors_choice=true" : "");

            try
            {
                using var resp = await client.GetAsync(url);
                if (!resp.IsSuccessStatusCode) return null;

                var json = await resp.Content.ReadAsStringAsync();
                var data = JsonSerializer.Deserialize<PixabayResponse>(json, _jsonOpts);
                var hits = data?.hits;
                if (hits == null || hits.Count == 0) return null;

                // stable per-name selection (so different dishes/restaurants don't all use hits[0])
                var idx = StableIndex($"{seed}|{q}", hits.Count);
                var h = hits[idx];

                return small
                    ? (h.webformatURL ?? h.largeImageURL ?? h.previewURL)
                    : (h.largeImageURL ?? h.webformatURL ?? h.previewURL);
            }
            catch
            {
                return null;
            }
        }

        private static int StableIndex(string seed, int count)
        {
            if (count <= 1) return 0;
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(seed ?? ""));
            int val = (bytes[0] | (bytes[1] << 8) | (bytes[2] << 16) | (bytes[3] << 24)) & int.MaxValue;
            return val % count;
        }
    }
}
