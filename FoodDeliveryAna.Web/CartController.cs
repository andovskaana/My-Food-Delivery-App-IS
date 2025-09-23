using System;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAna.Web
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ShoppingCartService _cartService;
        private readonly UserManager<FoodDeliveryApplicationUser> _userManager;

        public CartController(ShoppingCartService cartService, UserManager<FoodDeliveryApplicationUser> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Challenge();

            var cart = await _cartService.GetActiveCartAsync(userId);
            return View(cart);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Guid menuItemId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Challenge();

            if (quantity < 1) quantity = 1;
            await _cartService.AddItemToCartAsync(userId, menuItemId, quantity);

            var referer = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(referer)) return Redirect(referer);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(Guid cartItemId)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Challenge();

            await _cartService.RemoveItemAsync(userId, cartItemId);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// AJAX quantity update. Returns fresh item total and subtotal.
        /// Uses remove + add to set the new quantity (no special service method required).
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateQuantity([FromForm] Guid cartItemId, [FromForm] int quantity)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null) return Unauthorized();

            if (quantity < 1) quantity = 1;

            // Load cart to discover which menu item this cart item represents
            var cartBefore = await _cartService.GetActiveCartAsync(userId);
            var existing = cartBefore?.Items?.FirstOrDefault(i => i.Id == cartItemId);
            if (existing == null || existing.MenuItem == null)
                return BadRequest(new { ok = false, message = "Cart item not found." });

            var menuItemId = existing.MenuItem.Id;

            // Remove the old cart item entirely…
            await _cartService.RemoveItemAsync(userId, cartItemId);
            // …then add back with the desired quantity
            await _cartService.AddItemToCartAsync(userId, menuItemId, quantity);

            // Reload to compute totals
            var cart = await _cartService.GetActiveCartAsync(userId);
            var item = cart?.Items?.FirstOrDefault(i => i.MenuItem != null && i.MenuItem.Id == menuItemId);

            decimal itemTotal = 0m;
            if (item?.MenuItem != null)
                itemTotal = (item.MenuItem.Price) * item.Quantity;

            var subtotal = cart?.Items?.Sum(i => (i.MenuItem?.Price ?? 0m) * i.Quantity) ?? 0m;

            return Json(new
            {
                ok = true,
                itemTotal = itemTotal.ToString("N2") ,
                subtotal = subtotal.ToString("N2")
            });
        }
    }
}
