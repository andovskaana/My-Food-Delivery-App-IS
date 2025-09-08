using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Repository;

namespace FoodDeliveryAna.Web
{
    public class MenusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MenusController(ApplicationDbContext _context)
        {
            this._context = _context;
        }

        // GET: /Menus
        // Supports:
        //  - q=<text>                    (name/description search)
        //  - restaurant=<slug>           (e.g., amigos-centar from the pills)
        //  - restaurantId=<guid>         (optional direct filter)
        //  - menuId=<guid>               (optional direct filter)
        public async Task<IActionResult> Index(
             Guid? restaurantId,
             Guid? menuId,
             string? q,
             string? restaurant // slug coming from the view
         )
        {
            // Base query with necessary includes (DB-side)
            IQueryable<MenuItem> query = _context.MenuItems
                .Include(mi => mi.Menu)
                .ThenInclude(m => m.Restaurant);

            // Narrow by explicit ids first (DB-side)
            if (menuId.HasValue)
            {
                query = query.Where(mi => mi.MenuId == menuId.Value);
            }
            else if (restaurantId.HasValue)
            {
                query = query.Where(mi => mi.Menu != null && mi.Menu.RestaurantId == restaurantId.Value);
            }

            // Text search (DB-side)
            if (!string.IsNullOrWhiteSpace(q))
            {
                var ql = q.Trim().ToLower();
                query = query.Where(mi =>
                    EF.Functions.Like(mi.Name.ToLower(), $"%{ql}%") ||
                    (mi.Description != null && EF.Functions.Like(mi.Description.ToLower(), $"%{ql}%")));
            }

            // Order for stable UI (DB-side)
            query = query
                .OrderBy(mi => mi.Menu!.Restaurant!.Name)
                .ThenBy(mi => mi.Name);

            // Materialize to memory BEFORE applying Slugify (EF cannot translate custom methods)
            var items = await query
                .AsNoTracking()
                .ToListAsync();

            // Slug filter (client-side / in-memory)
            if (!string.IsNullOrWhiteSpace(restaurant))
            {
                var targetSlug = restaurant.Trim().ToLower();
                items = items
                    .Where(mi =>
                        mi?.Menu?.Restaurant?.Name != null &&
                        Slugify(mi.Menu.Restaurant.Name) == targetSlug)
                    .ToList();
            }

            // Pass current filters back to the view (optional)
            ViewBag.Q = q;
            ViewBag.Restaurant = restaurant;
            ViewBag.RestaurantId = restaurantId;
            ViewBag.MenuId = menuId;

            return View(items);
        }

        // GET: Menus/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null) return NotFound();

            var menu = await _context.Menus
                .Include(m => m.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (menu == null) return NotFound();

            return View(menu);
        }

        // GET: Menus/Create
        public IActionResult Create()
        {
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name");
            return View();
        }

        // POST: Menus/Create
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
            if (id == null) return NotFound();

            var menu = await _context.Menus.FindAsync(id);
            if (menu == null) return NotFound();

            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name", menu.RestaurantId);
            return View(menu);
        }

        // POST: Menus/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Title,RestaurantId,Id")] Menu menu)
        {
            if (id != menu.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(menu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MenuExists(menu.Id)) return NotFound();
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["RestaurantId"] = new SelectList(_context.Restaurants, "Id", "Name", menu.RestaurantId);
            return View(menu);
        }

        // GET: Menus/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null) return NotFound();

            var menu = await _context.Menus
                .Include(m => m.Restaurant)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (menu == null) return NotFound();

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

        // --- Shared with view: same slug logic the pills use ---
        private static string Slugify(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";
            var chars = s.Trim().ToLowerInvariant()
                .Select(ch => char.IsLetterOrDigit(ch) ? ch : '-')
                .ToArray();
            var slug = new string(chars);
            while (slug.Contains("--")) slug = slug.Replace("--", "-");
            return slug.Trim('-');
        }
    }
}
