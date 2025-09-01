//using Microsoft.AspNetCore.Identity;
using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Repository;
using FoodDeliveryAna.Web;
using FoodDeliveryAna.Web.Services;
using Microsoft.EntityFrameworkCore;
using Stripe;

// <-- add this

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
StripeConfiguration.ApiKey = builder.Configuration.GetValue<string>("Stripe:SecretKey");

// Add services to the container.

// HttpClient + Pixabay service
builder.Services.AddHttpClient("pixabay", c =>
{
    c.BaseAddress = new Uri("https://pixabay.com/api/");
});
builder.Services.AddSingleton<PixabayService>();   // <-- DI for our image service

builder.Services.AddMemoryCache();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Identity
builder.Services.AddDefaultIdentity<FoodDeliveryApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

// Register application services
builder.Services.AddScoped<FoodDeliveryAna.Service.ShoppingCartService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();   // <-- IMPORTANT with Identity
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

// Seed initial data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await FoodDeliveryAna.Repository.SeedData.InitializeAsync(services);
}

app.Run();
