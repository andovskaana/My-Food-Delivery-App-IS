using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Service
{
    // API DTO (matches JSON exactly)
    public sealed class RestaurantApiDto
    {
        [JsonPropertyName("restaurantName")] public string RestaurantName { get; set; } = "";
        [JsonPropertyName("restaurantSlug")] public string RestaurantSlug { get; set; } = "";
        [JsonPropertyName("rating")] public double? Rating { get; set; }
        [JsonPropertyName("openHours")] public Dictionary<string, string>? OpenHours { get; set; }
    }

    // View/domain model (computed IsOpen + TodayRange)
    public sealed class RestaurantOpenStatus
    {
        public string RestaurantName { get; init; } = "";
        public string RestaurantSlug { get; init; } = "";
        public bool IsOpen { get; init; }
        public string? TodayRange { get; init; }
        public double? Rating { get; init; }
    }

    public interface IRestaurantOpenStatusService
    {
        Task<IReadOnlyList<RestaurantOpenStatus>> GetStatusesAsync(CancellationToken ct = default);
        Task<bool> IsRestaurantOpenNowAsync(string restaurantName, CancellationToken ct = default);
    }

    public sealed class RestaurantOpenStatusService : IRestaurantOpenStatusService
    {
        private const string ApiUrl = "https://68bc32430f2491613ede51db.mockapi.io/api/fd_mk/restaurants";
        private static readonly string[] DayKeys = { "sun", "mon", "tue", "wed", "thu", "fri", "sat" };
        private readonly HttpClient _http;

        public RestaurantOpenStatusService(HttpClient http) => _http = http;

        public async Task<IReadOnlyList<RestaurantOpenStatus>> GetStatusesAsync(CancellationToken ct = default)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            using var resp = await _http.GetAsync(ApiUrl, ct);
            resp.EnsureSuccessStatusCode();

            await using var stream = await resp.Content.ReadAsStreamAsync(ct);
            var data = await JsonSerializer.DeserializeAsync<List<RestaurantApiDto>>(stream, options, ct)
                       ?? new List<RestaurantApiDto>();

            var nowLocal = GetNowInSkopje();
            var todayKey = DayKeys[(int)nowLocal.DayOfWeek]; // Sunday => 0 => "sun"

            var result = new List<RestaurantOpenStatus>(data.Count);
            foreach (var r in data)
            {
                var dayMap = r.OpenHours ?? new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                dayMap.TryGetValue(todayKey, out var todayRange);

                var isOpen = IsOpenAt(nowLocal, todayRange);
                result.Add(new RestaurantOpenStatus
                {
                    RestaurantName = r.RestaurantName ?? "",
                    RestaurantSlug = r.RestaurantSlug ?? "",
                    IsOpen = isOpen,
                    TodayRange = string.IsNullOrWhiteSpace(todayRange) ? "closed" : todayRange,
                    Rating = r.Rating
                });
            }
            return result;
        }

        public async Task<bool> IsRestaurantOpenNowAsync(string restaurantName, CancellationToken ct = default)
        {
            var statuses = await GetStatusesAsync(ct);
            foreach (var s in statuses)
                if (string.Equals(s.RestaurantName, restaurantName, StringComparison.OrdinalIgnoreCase))
                    return s.IsOpen;
            return false;
        }

        // ---- time helpers ----

        private static DateTime GetNowInSkopje()
        {
            // Cross-platform: try IANA first, then Windows ID
            TimeZoneInfo tz;
            try { tz = TimeZoneInfo.FindSystemTimeZoneById("Europe/Skopje"); }
            catch { tz = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time"); }
            return TimeZoneInfo.ConvertTime(DateTime.UtcNow, tz);
        }

        private static bool IsOpenAt(DateTime localNow, string? range)
        {
            if (string.IsNullOrWhiteSpace(range) || range.Equals("closed", StringComparison.OrdinalIgnoreCase))
                return false;

            var parts = range.Split('-', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 2) return false;

            var start = ToMinutes(parts[0]);
            var end = ToMinutes(parts[1]);
            if (start < 0 || end < 0) return false;

            var nowMinutes = localNow.Hour * 60 + localNow.Minute;

            // 24:00 => end-of-day
            if (end == 1440)
                return nowMinutes >= start && nowMinutes < 1440;

            // Overnight (e.g., 10:00-01:00)
            if (end <= start)
                return nowMinutes >= start || nowMinutes < end;

            // Same-day range
            return nowMinutes >= start && nowMinutes < end;
        }

        private static int ToMinutes(string hhmm)
        {
            if (string.Equals(hhmm, "24:00", StringComparison.Ordinal)) return 1440;
            if (!TimeSpan.TryParseExact(hhmm, "hh\\:mm", CultureInfo.InvariantCulture, out var ts)) return -1;
            return (int)ts.TotalMinutes;
        }
    }
}
