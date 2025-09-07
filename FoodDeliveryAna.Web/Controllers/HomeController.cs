using FoodDeliveryAna.Domain.DomainModels;
using FoodDeliveryAna.Service;
using FoodDeliveryAna.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FoodDeliveryAna.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRestaurantOpenStatusService _statusService;

        public HomeController(ILogger<HomeController> logger, IRestaurantOpenStatusService statusService)
        {
            _logger = logger;
            _statusService = statusService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // e.g., show a landing page with the open/closed tag from the API
        public async Task<IActionResult> OpenNow()
        {
            var statuses = await _statusService.GetStatusesAsync();
            var vms = statuses.Select(s => new RestaurantStatusDTO
            {
                RestaurantName = s.RestaurantName ?? "",
                RestaurantSlug = s.RestaurantSlug ?? "",
                IsOpen = s.IsOpen,
                TodayRange = string.IsNullOrWhiteSpace(s.TodayRange) ? "closed" : s.TodayRange,
                Rating = s.Rating
            }).ToList();

            return View(vms);
        }
    }
}
