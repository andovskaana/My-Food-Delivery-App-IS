using FoodDeliveryAna.Domain.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Web.Areas.Identity.Pages.Account.Manage
{
    [Authorize]
    public class PersonalDataModel : PageModel
    {
        private readonly UserManager<FoodDeliveryApplicationUser> _userManager;

        public PersonalDataModel(UserManager<FoodDeliveryApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {
            // Placeholder for your deletion workflow or redirect to a confirmation page.
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound("User not found.");

            TempData["StatusMessage"] = "Account deletion requested (stub).";
            return RedirectToPage("./Index");
        }
    }
}
