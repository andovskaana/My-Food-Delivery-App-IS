using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Repository;
using FoodDeliveryAna.Web.Services;

namespace FoodDeliveryAna.Web
{
    public class MenusController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly PixabayService _pixabay;

        public MenusController(ApplicationDbContext _context, PixabayService pixabay)
        {
            this._context = _context;
            _pixabay = pixabay;
        }

        // GET: Menus
        public async Task<IActionResult> Index(Guid? restaurantId, Guid? menuId, string? q, string? category)
        {
            // Base query: all items with their Menu and Restaurant for display
            IQueryable<MenuItem> qy = _context.MenuItems
                .Include(i => i.Menu)
                .ThenInclude(m => m.Restaurant);

            // Filter by menu or restaurant if provided (supports /Menus?restaurantId=... or /Menus?menuId=...)
            if (menuId.HasValue)
                qy = qy.Where(i => i.MenuId == menuId.Value);
            else if (restaurantId.HasValue)
                qy = qy.Where(i => i.Menu != null && i.Menu.RestaurantId == restaurantId.Value);

            // Text search
            if (!string.IsNullOrWhiteSpace(q))
            {
                var ql = q!.ToLower();
                qy = qy.Where(i => i.Name.ToLower().Contains(ql));
            }

            // Category filter (keyword-based matching on item name)
            if (!string.IsNullOrWhiteSpace(category))
            {
                var cat = category!.ToLower();
                qy = cat switch
                {
                    "pizza" => qy.Where(i => i.Name.ToLower().Contains("pizza")),
                    "burgers" or "burger" => qy.Where(i => i.Name.ToLower().Contains("burger")),
                    "sushi" => qy.Where(i => i.Name.ToLower().Contains("sushi")),
                    "dessert" or "desserts" =>
                        qy.Where(i =>
                            i.Name.ToLower().Contains("dessert") ||
                            i.Name.ToLower().Contains("cake") ||
                            i.Name.ToLower().Contains("ice")),
                    _ => qy
                };
            }

            var items = await qy.ToListAsync();

            // Fetch images concurrently (and cached). Use the faster "small" variant.
            var imageTasks = items.Select(async it =>
            {
                if (string.IsNullOrWhiteSpace(it.ImageUrl))
                    it.ImageUrl = await _pixabay.GetImageUrlAsync(it.Name, small: true);
            });
            await Task.WhenAll(imageTasks);

            return View(items);
        }




        //public async Task<IActionResult> Index()
        //{
        //    var applicationDbContext = _context.Menus.Include(m => m.Restaurant);
        //    return View(await applicationDbContext.ToListAsync());
        //}

        // GET: Menus/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // GET: Menus/Create
        public IActionResult Create()
        {
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name");
            return View();
        }

        // POST: Menus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,RestaurantId,Id")] Menu menu)
        {
            if (ModelState.IsValid)
            {
                menu.Id = Guid.NewGuid();
                _context.Add(menu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name", menu.RestaurantId);
            return View(menu);
        }

        // GET: Menus/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null)
            {
                return NotFound();
            }
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name", menu.RestaurantId);
            return View(menu);
        }

        // POST: Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Title,RestaurantId,Id")] Menu menu)
        {
            if (id != menu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuExists(menu.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name", menu.RestaurantId);
            return View(menu);
        }

        // GET: Menus/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var menu = await _context.Menus
                .Include(m => m.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return View(menu);
        }

        // POST: Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var menu = await _context.Menus.FindAsync(id);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MenuExists(Guid id)
        {
            return _context.Menus.Any(e => e.Id == id);
        }
    }
}
