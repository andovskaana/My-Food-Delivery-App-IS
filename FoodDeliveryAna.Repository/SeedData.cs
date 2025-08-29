using FoodDeliveryAna.Domain.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Repository
{
    /// <summary>
    /// Seeds the database with a predefined set of restaurants, menus and menu
    /// items.  The seed contains popular Skopje eateries along with opening
    /// hours, ratings and sample dishes.  If any restaurants already exist
    /// the method exits early so that data is not duplicated.  When adding
    /// new entries to this list ensure that the accompanying citation lines
    /// from our research remain accurate (see final answer for references).
    /// </summary>
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            // apply pending migrations and create the database if it does not exist
            await context.Database.MigrateAsync();
            if (context.Restaurants.Any())
            {
                return; // DB has been seeded
            }

            var restaurants = new List<Restaurant>();

            // 1. Amigos Mexican Restaurant & Bar – rating and hours from RestaurantGuru【196274765203636†L78-L79】【196274765203636†L184-L186】
            restaurants.Add(CreateRestaurant(
                name: "Amigos Mexican Restaurant & Bar",
                description: "Casual Mexican restaurant offering tacos, burritos and other Tex‑Mex favourites.",
                city: "Skopje",
                streetAddress: "Makedonija 11",
                openingHours: "Daily 09:30–24:00",
                rating: 4.5m
            , new[]
            {
                CreateMenuItem("Tacos", 5.50m),
                CreateMenuItem("Burrito", 6.00m),
                CreateMenuItem("Quesadilla", 6.50m)
            }));

            // 2. Skopski Merak – rating and hours from RestaurantGuru【770166994127041†L72-L77】【770166994127041†L187-L193】
            restaurants.Add(CreateRestaurant(
                name: "Skopski Merak",
                description: "Traditional Macedonian restaurant with live music and a cosy atmosphere.",
                city: "Skopje",
                streetAddress: "Debarca St 51",
                openingHours: "Sun 12:00–24:00, Mon–Thu 09:00–24:00, Fri–Sat 09:00–01:00",
                rating: 4.6m
            , new[]
            {
                CreateMenuItem("Grilled Pork", 8.00m),
                CreateMenuItem("Shopska Salad", 4.00m),
                CreateMenuItem("Tavche Gravche", 5.50m)
            }));

            // 3. Old House – rating and hours from RestaurantGuru【998813419478714†L97-L100】【998813419478714†L184-L188】
            restaurants.Add(CreateRestaurant(
                name: "Old House",
                description: "Historic restaurant serving Macedonian classics in a rustic setting.",
                city: "Skopje",
                streetAddress: "Boulevard Phillip II of Macedon 14",
                openingHours: "Sun 14:00–22:00, Mon–Thu 09:00–24:00, Fri–Sat 09:00–24:00",
                rating: 4.5m
            , new[]
            {
                CreateMenuItem("Roasted Lamb", 10.00m),
                CreateMenuItem("Macedonian Salad", 4.00m),
                CreateMenuItem("Burek", 3.00m)
            }));

            // 4. Pelister – rating and hours from RestaurantGuru【88153275760272†L76-L77】【88153275760272†L179-L210】
            restaurants.Add(CreateRestaurant(
                name: "Pelister",
                description: "Modern bistro located on Macedonia Square, known for pizzas and pastas.",
                city: "Skopje",
                streetAddress: "Boulevard Macedonia",
                openingHours: "Mon–Fri 09:00–24:00, Sat–Sun 10:00–24:00",
                rating: 4.4m
            , new[]
            {
                CreateMenuItem("Pizza Margherita", 6.00m),
                CreateMenuItem("Chicken Pasta", 7.50m),
                CreateMenuItem("Caesar Salad", 5.50m)
            }));

            // 5. Forza Wine Bar & Restaurant – rating and hours from Nova Circle【992153790998766†L84-L87】【992153790998766†L101-L129】
            restaurants.Add(CreateRestaurant(
                name: "Forza Wine Bar & Restaurant",
                description: "Stylish wine bar offering Mediterranean cuisine and an extensive wine list.",
                city: "Skopje",
                streetAddress: "Londonska 12a",
                openingHours: "Mon–Thu 08:00–24:00, Fri–Sat 08:00–01:00, Sun 08:00–24:00",
                rating: 4.1m
            , new[]
            {
                CreateMenuItem("Wine & Cheese Platter", 12.00m),
                CreateMenuItem("Pasta Carbonara", 8.50m),
                CreateMenuItem("Risotto", 9.00m)
            }));

            // 6. La Terrazza – rating and hours from Wanderlog【124284016601873†L26-L44】【124284016601873†L68-L83】
            restaurants.Add(CreateRestaurant(
                name: "La Terrazza",
                description: "Popular Italian restaurant located at Macedonia Square with outdoor seating.",
                city: "Skopje",
                streetAddress: "Plostad Makedonija 2/4",
                openingHours: "Sun 10:00–24:00, Mon–Thu 08:00–24:00, Fri–Sat 09:00–01:00",
                rating: 4.4m
            , new[]
            {
                CreateMenuItem("Pasta Carbonara", 8.00m),
                CreateMenuItem("Seafood Risotto", 9.50m),
                CreateMenuItem("Tiramisu", 4.50m)
            }));

            // 7. Vodenica Mulino – rating and hours from Wanderlog【424905705594091†L26-L44】【424905705594091†L70-L86】
            restaurants.Add(CreateRestaurant(
                name: "Vodenica Mulino",
                description: "Romantic riverside venue offering Italian dishes and a large wine selection.",
                city: "Skopje",
                streetAddress: "Mitropolit Teodosij Gologanov 69",
                openingHours: "Mon–Sat 12:00–24:00, Sun Closed",
                rating: 4.6m
            , new[]
            {
                CreateMenuItem("Seafood Pasta Tagliatelle", 12.00m),
                CreateMenuItem("Mixed Cheese Platter", 10.00m),
                CreateMenuItem("Lava Cake", 5.00m)
            }));

            // 8. Gostilnica Dukat – rating and hours from Wanderlog【242083552771841†L26-L44】【242083552771841†L69-L104】
            restaurants.Add(CreateRestaurant(
                name: "Gostilnica Dukat",
                description: "Family style restaurant serving traditional Macedonian food and live music.",
                city: "Skopje",
                streetAddress: "Boulevard Mitropolit Teodosij Gologanov 79",
                openingHours: "Sun 09:00–24:00, Mon–Thu 09:00–24:00, Fri–Sat 09:00–01:00",
                rating: 4.6m
            , new[]
            {
                CreateMenuItem("Fish Soup (Riblja Čorba)", 7.00m),
                CreateMenuItem("Grilled Trout", 10.00m),
                CreateMenuItem("Traditional Pork Dish", 8.00m)
            }));

            // 9. Matto Napoletano – hours and address from Skopje Daily Tours article【686800330085059†L141-L145】
            restaurants.Add(CreateRestaurant(
                name: "Matto Napoletano",
                description: "Neapolitan pizzeria ranked among the top European pizzerias.",
                city: "Skopje",
                streetAddress: "Debarca 2a",
                openingHours: "Daily 08:00–23:30",
                rating: 4.5m
            , new[]
            {
                CreateMenuItem("Margherita Pizza", 7.00m),
                CreateMenuItem("Prosciutto Pizza", 9.00m),
                CreateMenuItem("Tiramisu", 4.50m)
            }));

            // 10. Pizza & Pasta Enriko – rating and hours from Wanderlog【888587751637569†L26-L44】【888587751637569†L69-L83】
            restaurants.Add(CreateRestaurant(
                name: "Pizza & Pasta Enriko",
                description: "Italian eatery known for unconventional pizza flavours and hearty sandwiches.",
                city: "Skopje",
                streetAddress: "T.C. Leptokarija, Blvd. Partizanski Odredi",
                openingHours: "Sun 10:00–24:00, Mon–Thu 08:00–24:00, Fri–Sat 08:00–01:00",
                rating: 4.5m
            , new[]
            {
                CreateMenuItem("Curry Pizza", 9.00m),
                CreateMenuItem("Kulen Sandwich", 5.50m),
                CreateMenuItem("Pasta al dente", 7.50m)
            }));

            // persist all restaurants, menus and items
            foreach (var rest in restaurants)
            {
                context.Restaurants.Add(rest);
            }
            await context.SaveChangesAsync();
        }
        private static Restaurant CreateRestaurant(string name, string description, string city, string streetAddress, string openingHours, decimal rating, MenuItem[] menuItems)
        {
            return CreateRestaurant(name, description, city, streetAddress, openingHours, rating, (IEnumerable<MenuItem>)menuItems);
        }
        //private static Restaurant CreateRestaurant(string name, string description, string city, string streetAddress, string openingHours, decimal rating, MenuItem[] menuItems)
        //{
        //    throw new NotImplementedException();
        //}

        private static Restaurant CreateRestaurant(string name, string description, string city, string streetAddress, string openingHours, decimal rating,  IEnumerable<MenuItem> items)
        {
            var restaurant = new Restaurant
            {
                Id = Guid.NewGuid(),
                Name = name,
                Description = description,
                City = city,
                StreetAddress = streetAddress,
                OpeningHours = openingHours,
                Rating = rating,
            };
            var menu = new Menu
            {
                Id = Guid.NewGuid(),
                Title = "Main Menu",
                RestaurantId = restaurant.Id
            };
            foreach (var item in items)
            {
                item.Id = Guid.NewGuid();
                item.MenuId = menu.Id;
                menu.Items.Add(item);
            }
            restaurant.Menus.Add(menu);
            return restaurant;
        }

        private static MenuItem CreateMenuItem(string name, decimal price)
        {
            return new MenuItem
            {
                Name = name,
                Price = price
            };
        }
    }
}