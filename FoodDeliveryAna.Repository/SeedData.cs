using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Domain.Identity;
using Microsoft.AspNetCore.Identity;
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
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<FoodDeliveryApplicationUser>>();

            await context.Database.MigrateAsync();

            // 1) Ensure roles exist
            string[] roles = new[] { "Admin", "Courier", "Customer" };
            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            // 2) Ensure default admin
            var adminEmail = "admin@food.app";
            var admin = await userManager.FindByEmailAsync(adminEmail);
            if (admin == null)
            {
                admin = new FoodDeliveryApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    FirstName = "System",
                    LastName = "Admin"
                };
                var result = await userManager.CreateAsync(admin, "Admin!123"); // change after first run
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "Admin");
                }
            }

            // 3) Seed domain data only once
            if (!context.Restaurants.Any())
            {
                var restaurants = HardcodedData.GetRestaurants();
                context.Restaurants.AddRange(restaurants);
                await context.SaveChangesAsync();
            }
        }
    }
}
