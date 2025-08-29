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

namespace FoodDeliveryAna.Web
{
    /// <summary>
    /// The CartController exposes actions for viewing and modifying the current
    /// user's shopping cart.  It relies on the <see cref="ShoppingCartService"/>
    /// to perform all data access and manipulation.  Users must be logged in
    /// to interact with their cart.
    /// </summary>
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

        /// <summary>
        /// Displays the current user's cart with all items and totals.
        /// </summary>
        public async Task<IActionResult> Index()
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }
            var cart = await _cartService.GetActiveCartAsync(userId);
            return View(cart);
        }

        /// <summary>
        /// Handles the Add to cart POST from the restaurant details view.  If the
        /// quantity is not specified or less than 1, a default of 1 is used.
        /// After adding the item the user is redirected back to the referring
        /// page (if available) or to the cart index.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Guid menuItemId, int quantity = 1)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }
            if (quantity < 1) quantity = 1;
            await _cartService.AddItemToCartAsync(userId, menuItemId, quantity);
            // Redirect back to the previous page if available
            var referer = Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(referer))
            {
                return Redirect(referer);
            }
            return RedirectToAction("Index");
        }

        /// <summary>
        /// Removes the specified cart item from the current user's cart.
        /// </summary>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Remove(Guid cartItemId)
        {
            var userId = _userManager.GetUserId(User);
            if (userId == null)
            {
                return Challenge();
            }
            await _cartService.RemoveItemAsync(userId, cartItemId);
            return RedirectToAction(nameof(Index));
        }
    }
}