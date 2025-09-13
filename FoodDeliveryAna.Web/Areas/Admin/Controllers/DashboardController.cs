using FoodDeliveryAna.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// ?? NEW:
using FoodDeliveryAna.Domain.Identity;
using Microsoft.AspNetCore.Identity;

namespace FoodDeliveryAna.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Policy = "RequireAdmin")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;

        //  NEW:
        private readonly UserManager<FoodDeliveryApplicationUser> _users;
        private readonly RoleManager<IdentityRole> _roles;

        //  CHANGED: inject managers
        public DashboardController(
            ApplicationDbContext db,
            UserManager<FoodDeliveryApplicationUser> users,
            RoleManager<IdentityRole> roles)
        {
            _db = db;
            _users = users;
            _roles = roles;
        }

        public async Task<IActionResult> Index()
        {
            var orders = await _db.Orders
                .Include(o => o.Owner)
                .Include(o => o.Courier)
                .OrderByDescending(o => o.CreatedAt)
                .Take(50)
                .ToListAsync();

            ViewBag.RestaurantCount = await _db.Restaurants.CountAsync();
            ViewBag.OrderCount = await _db.Orders.CountAsync();
            ViewBag.UserCount = await _db.Users.CountAsync();

            //  NEW: load recent users with roles for the Users table
            var lastUsers = _users.Users
                                  .OrderByDescending(u => u.Id)
                                  .Take(50)
                                  .ToList();

            var userRows = new List<UserRow>();
            foreach (var u in lastUsers)
            {
                var roles = await _users.GetRolesAsync(u);
                userRows.Add(new UserRow
                {
                    Id = u.Id,
                    Email = u.Email ?? "",
                    Name = $"{u.FirstName} {u.LastName}".Trim(),
                    RolesCsv = string.Join(", ", roles)
                });
            }
            ViewBag.Users = userRows;

            return View(orders);
        }

        // Lightweight row-DTO for the table
        public class UserRow
        {
            public string Id { get; set; } = "";
            public string Email { get; set; } = "";
            public string Name { get; set; } = "";
            public string RolesCsv { get; set; } = "";
        }

        // ---------- CRUD ----------

        // GET: /Admin/Dashboard/CreateUser
        [HttpGet]
        public IActionResult CreateUser() => View();

        // POST: /Admin/Dashboard/CreateUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(CreateUserVm vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var user = new FoodDeliveryApplicationUser
            {
                Email = vm.Email,
                UserName = vm.Email,
                FirstName = vm.FirstName,
                LastName = vm.LastName,
                Address = vm.Address,
                EmailConfirmed = true
            };
            var result = await _users.CreateAsync(user, vm.Password);
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors) ModelState.AddModelError("", e.Description);
                return View(vm);
            }

            // ensure roles exist
            async Task Ensure(string r) { if (!await _roles.RoleExistsAsync(r)) await _roles.CreateAsync(new IdentityRole(r)); }
            await Ensure("Admin"); await Ensure("Courier"); await Ensure("Customer");

            if (vm.AsAdmin) await _users.AddToRoleAsync(user, "Admin");
            if (vm.AsCourier) await _users.AddToRoleAsync(user, "Courier");
            if (vm.AsCustomer) await _users.AddToRoleAsync(user, "Customer");

            return RedirectToAction(nameof(Index));
        }

        // GET: /Admin/Dashboard/EditUser/{id}
        [HttpGet]
        public async Task<IActionResult> EditUser(string id)
        {
            var u = await _users.FindByIdAsync(id);
            if (u == null) return NotFound();

            var vm = new EditUserVm
            {
                Id = u.Id,
                Email = u.Email ?? "",
                FirstName = u.FirstName ?? "",
                LastName = u.LastName ?? "",
                Address = u.Address,
                IsAdmin = await _users.IsInRoleAsync(u, "Admin"),
                IsCourier = await _users.IsInRoleAsync(u, "Courier"),
                IsCustomer = await _users.IsInRoleAsync(u, "Customer")
            };
            return View(vm);
        }

        // POST: /Admin/Dashboard/EditUser
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(EditUserVm vm)
        {
            if (!ModelState.IsValid) return View(vm);

            var u = await _users.FindByIdAsync(vm.Id);
            if (u == null) return NotFound();

            u.Email = vm.Email; u.UserName = vm.Email;
            u.FirstName = vm.FirstName; u.LastName = vm.LastName; u.Address = vm.Address;

            var result = await _users.UpdateAsync(u);
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors) ModelState.AddModelError("", e.Description);
                return View(vm);
            }

            async Task SetRole(string r, bool on)
            {
                var has = await _users.IsInRoleAsync(u, r);
                if (on && !has) await _users.AddToRoleAsync(u, r);
                if (!on && has) await _users.RemoveFromRoleAsync(u, r);
            }
            await SetRole("Admin", vm.IsAdmin);
            await SetRole("Courier", vm.IsCourier);
            await SetRole("Customer", vm.IsCustomer);

            return RedirectToAction(nameof(Index));
        }

        // POST: /Admin/Dashboard/DeleteUser/{id}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var u = await _users.FindByIdAsync(id);
            if (u == null) return NotFound();
            await _users.DeleteAsync(u);
            return RedirectToAction(nameof(Index));
        }
    }

    // ---------- ViewModels (kept here to avoid extra files) ----------
    public class CreateUserVm
    {
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.MinLength(6)]
        [System.ComponentModel.DataAnnotations.DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required] public string FirstName { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required] public string LastName { get; set; } = "";
        public string? Address { get; set; }
        public bool AsAdmin { get; set; } = false;
        public bool AsCourier { get; set; } = false;
        public bool AsCustomer { get; set; } = true;
    }

    public class EditUserVm
    {
        [System.ComponentModel.DataAnnotations.Required]
        public string Id { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required, System.ComponentModel.DataAnnotations.EmailAddress]
        public string Email { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required] public string FirstName { get; set; } = "";
        [System.ComponentModel.DataAnnotations.Required] public string LastName { get; set; } = "";
        public string? Address { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsCourier { get; set; }
        public bool IsCustomer { get; set; }
    }
}
