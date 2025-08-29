using System;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Repository;
using FoodDeliveryAna.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAna.Web
{
    /// <summary>
    /// Handles the checkout flow and allows users to view their past orders.
    /// Payment integration is mocked; we simply display the summary and create
    /// an order upon confirmation.
    /// </summary>
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly ShoppingCartService _cartService;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<FoodDeliveryApplicationUser> _userManager;

        public OrdersController(ShoppingCartService cartService, ApplicationDbContext context, UserManager<FoodDeliveryApplicationUser> userManager)
        {
            _cartService = cartService;
            _context = context;
            _userManager = userManager;
        }

        /// <summary>
        /// Shows a summary of the current cart and collects payment details.  Since
        /// this is a demo we simply display a message about using Stripe test
        /// numbers.  Users can confirm to place the order.
        /// </summary>
        public async Task<IActionResult> Checkout()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }
            var cart = await _cartService.GetActiveCartAsync(userId);
            if (cart.Items == null || !cart.Items.Any())
            {
                return RedirectToAction("Index", "Cart");
            }
            return View(cart);
        }

        /// <summary>
        /// Processes the checkout by creating an Order from the cart.  A real
        /// implementation would integrate with a payment gateway and only
        /// create the order upon successful payment.  Here we assume
        /// success and clear the cart.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CheckoutConfirm()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }
            var cart = await _cartService.GetActiveCartAsync(userId);
            if (cart.Items == null || !cart.Items.Any())
            {
                return RedirectToAction("Index", "Cart");
            }
            // Calculate total and create order
            decimal total = 0;
            var order = new Order
            {
                Id = Guid.NewGuid(),
                OwnerId = userId,
                CreatedAt = DateTime.UtcNow,
                Total = 0m
            };
            foreach (var cartItem in cart.Items)
            {
                var price = cartItem.MenuItem?.Price ?? 0m;
                var sub = price * cartItem.Quantity;
                total += sub;
                var orderItem = new OrderItem
                {
                    Id = Guid.NewGuid(),
                    MenuItemId = cartItem.MenuItemId,
                    MenuItemName = cartItem.MenuItem?.Name ?? string.Empty,
                    UnitPrice = price,
                    Quantity = cartItem.Quantity,
                    OrderId = order.Id
                };
                order.Items.Add(orderItem);
            }
            order.Total = total;
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
            await _cartService.ClearCartAsync(userId);
            return RedirectToAction(nameof(Success), new { id = order.Id });
        }

        /// <summary>
        /// Shows a success page after an order has been placed.  Displays order
        /// details and a thank you message.
        /// </summary>
        public async Task<IActionResult> Success(Guid id)
        {
            var userId = _userManager.GetUserId(User);
            var order = await _context.Orders
                .Include(o => o.Items)
                .FirstOrDefaultAsync(o => o.Id == id && o.OwnerId == userId);
            if (order == null) return NotFound();
            return View(order);
        }

        /// <summary>
        /// Shows the order history for the current user.
        /// </summary>
        public async Task<IActionResult> History()
        {
            var userId = _userManager.GetUserId(User);
            var orders = await _context.Orders
                .Where(o => o.OwnerId == userId)
                .OrderByDescending(o => o.CreatedAt)
                .Include(o => o.Items)
                .ToListAsync();
            return View(orders);
        }
    }
}