using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryAna.Web.Controllers
{
    public class PaymentControllerPages : Controller
    {
        [HttpGet("/Payment")]
        public IActionResult Index() => View();

        [HttpGet("/Payment/Success")]
        public IActionResult Success() => View();

        [HttpGet("/Payment/Fail")]
        public IActionResult Fail() => View();
    }
}
