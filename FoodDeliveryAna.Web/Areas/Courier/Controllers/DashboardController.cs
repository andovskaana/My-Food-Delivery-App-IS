using FoodDeliveryAna.Domain.Enums;
using FoodDeliveryAna.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryAna.Domain.Identity;

namespace FoodDeliveryAna.Web.Areas.Courier.Controllers
{
    [Area("Courier")]
    [Authorize(Policy = "RequireCourier")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<FoodDeliveryApplicationUser> _users;

        public DashboardController(ApplicationDbContext db, UserManager<FoodDeliveryApplicationUser> users)
        {
            _db = db; _users = users;
        }


        public async Task<IActionResult> Index()
        {
            var user = await _users.GetUserAsync(User);
            var myOrders = await _db.Orders
                 .Where(o => o.CourierId == user.Id || (o.CourierId == null && o.Status == OrderStatus.Placed))
                 .Include(o => o.Items)
                     .ThenInclude(i => i.MenuItem)
                         .ThenInclude(mi => mi.Menu)
                             .ThenInclude(m => m.Restaurant)
                 .Include(o => o.Owner) // if you show owner info/address stored on the user
                 .OrderBy(o => o.Status)
                 .ThenByDescending(o => o.CreatedAt)
                 .ToListAsync();
            return View(myOrders);
        }

        //public async Task<IActionResult> Index()
        //{
        //    var user = await _users.GetUserAsync(User);
        //    var myOrders = await _db.Orders
        //        .Where(o => o.CourierId == user.Id || (o.CourierId == null && o.Status == OrderStatus.Placed))
        //        .OrderBy(o => o.Status)
        //        .ThenByDescending(o => o.CreatedAt)
        //        .ToListAsync();
        //    return View(myOrders);
        //}

        // Accept (assign to current courier)
        [HttpPost]
        public async Task<IActionResult> Accept(Guid id)
        {
            var user = await _users.GetUserAsync(User);
            var order = await _db.Orders.FindAsync(id);
            if (order == null) return NotFound();
            if (order.Status != OrderStatus.Placed) return BadRequest();

            order.Status = OrderStatus.Accepted;
            order.CourierId = user.Id;
            order.AcceptedAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Start delivery (picked up)
        [HttpPost]
        public async Task<IActionResult> StartDelivery(Guid id)
        {
            var user = await _users.GetUserAsync(User);
            var order = await _db.Orders.FindAsync(id);
            if (order == null) return NotFound();
            if (order.CourierId != user.Id) return Forbid();
            if (order.Status != OrderStatus.Accepted) return BadRequest();

            order.Status = OrderStatus.PickedUp;
            order.PickedUpAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // Mark delivered
        [HttpPost]
        public async Task<IActionResult> MarkDelivered(Guid id)
        {
            var user = await _users.GetUserAsync(User);
            var order = await _db.Orders.FindAsync(id);
            if (order == null) return NotFound();
            if (order.CourierId != user.Id) return Forbid();
            if (order.Status != OrderStatus.PickedUp) return BadRequest();

            order.Status = OrderStatus.Delivered;
            order.DeliveredAt = DateTime.UtcNow;

            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
