using System;
using System.Linq;
using System.Threading.Tasks;
using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliveryAna.Service
{
    /// <summary>
    /// Provides high level operations for managing a user's shopping cart.  The
    /// cart is persisted in the database and linked to the authenticated user
    /// via their identity ID.  When a user adds an item we either update an
    /// existing CartItem or create a new one.  Removing items and clearing
    /// carts is also supported.  Consumers should inject this service and
    /// avoid accessing the DbContext directly for cart logic.
    /// </summary>
    public class ShoppingCartService
    {
        private readonly ApplicationDbContext _context;

        public ShoppingCartService(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieves the current cart for the specified user.  If no cart
        /// exists a new one will be created and persisted.  Related
        /// MenuItem entities are eagerly loaded so callers can access
        /// product information without additional queries.
        /// </summary>
        /// <param name="userId">The identity ID of the user.</param>
        public async Task<ShoppingCart> GetActiveCartAsync(string userId)
        {
            var cart = await _context.ShoppingCarts
                .Include(c => c.Items)
                    .ThenInclude(i => i.MenuItem)
                .FirstOrDefaultAsync(c => c.OwnerId == userId);
            if (cart == null)
            {
                cart = new ShoppingCart
                {
                    Id = Guid.NewGuid(),
                    OwnerId = userId
                };
                _context.ShoppingCarts.Add(cart);
                await _context.SaveChangesAsync();
            }
            return cart;
        }

        /// <summary>
        /// Adds a product to the user's cart.  If the product already exists
        /// in the cart its quantity is incremented.  Otherwise a new
        /// CartItem row is created.
        /// </summary>
        /// <param name="userId">Identity ID of the user.</param>
        /// <param name="menuItemId">ID of the menu item to add.</param>
        /// <param name="quantity">Number of items to add.</param>
        public async Task AddItemToCartAsync(string userId, Guid menuItemId, int quantity)
        {
            var cart = await GetActiveCartAsync(userId);
            var existing = cart.Items.FirstOrDefault(ci => ci.MenuItemId == menuItemId);
            if (existing != null)
            {
                existing.Quantity += quantity;
                _context.CartItems.Update(existing);
            }
            else
            {
                var cartItem = new CartItem
                {
                    Id = Guid.NewGuid(),
                    MenuItemId = menuItemId,
                    Quantity = quantity,
                    ShoppingCartId = cart.Id
                };
                cart.Items.Add(cartItem);
                _context.CartItems.Add(cartItem);
            }
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Removes the specified cart item from the user's cart.  If the
        /// item does not exist this operation is a no-op.
        /// </summary>
        public async Task RemoveItemAsync(string userId, Guid cartItemId)
        {
            var cart = await GetActiveCartAsync(userId);
            var item = cart.Items.FirstOrDefault(ci => ci.Id == cartItemId);
            if (item != null)
            {
                cart.Items.Remove(item);
                _context.CartItems.Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Removes all items from the user's cart.
        /// </summary>
        public async Task ClearCartAsync(string userId)
        {
            var cart = await GetActiveCartAsync(userId);
            _context.CartItems.RemoveRange(cart.Items);
            cart.Items.Clear();
            await _context.SaveChangesAsync();
        }
    }
}