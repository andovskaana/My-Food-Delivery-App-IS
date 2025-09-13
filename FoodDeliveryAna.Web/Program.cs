using Microsoft.AspNetCore.Identity; // <— needed for IdentityRole
using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Repository;
using FoodDeliveryAna.Web;
using FoodDeliveryAna.Service;
using Microsoft.EntityFrameworkCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

// Stripe
builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
StripeConfiguration.ApiKey = builder.Configuration.GetValue<string>("Stripe:SecretKey");

// DbContext
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Identity WITH roles + EF stores
builder.Services
    .AddDefaultIdentity<FoodDeliveryApplicationUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        // (optional) password rules if you want:
        // options.Password.RequiredLength = 6;
        // options.Password.RequireNonAlphanumeric = false;
    })
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Authorization policies for your three roles
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("RequireAdmin", policy => policy.RequireRole("Admin"));
    options.AddPolicy("RequireCourier", policy => policy.RequireRole("Courier"));
    options.AddPolicy("RequireCustomer", policy => policy.RequireRole("Customer"));
});

// MVC + Razor Pages (Identity UI, Areas, etc.)
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// HttpClient + app services
builder.Services.AddHttpClient<IRestaurantOpenStatusService, RestaurantOpenStatusService>();
builder.Services.AddScoped<FoodDeliveryAna.Service.ShoppingCartService>();

var app = builder.Build();

// Pipeline
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

app.UseAuthentication();   // Identity cookies
app.UseAuthorization();

// Area routes (Admin & Courier)
app.MapAreaControllerRoute(
    name: "admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "courier",
    areaName: "Courier",
    pattern: "Courier/{controller=Dashboard}/{action=Index}/{id?}");

// Default route + Identity pages
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

// Seed roles, default admin, and sample data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    await SeedData.InitializeAsync(services);
}

app.Run();
