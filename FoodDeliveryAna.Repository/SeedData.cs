using FoodDeliveryAna.Domain.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Repository
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // Create / migrate DB
            await context.Database.MigrateAsync();

            // Already seeded?
            if (context.Restaurants.Any()) return;

            // Pull everything from HardcodedData (mirrors Java DataInitializer)
            var restaurants = HardcodedData.GetRestaurants();

            // Save all (restaurants -> menus -> items)
            context.Restaurants.AddRange(restaurants);
            await context.SaveChangesAsync();
        }
    }
}
