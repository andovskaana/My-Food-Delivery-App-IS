using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using FoodDeliveryAna.Domain.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDeliveryAna.Web.Areas.Identity.Pages.Account.Manage
{
    [Authorize]
    public class AddressModel : PageModel
    {
        private readonly UserManager<FoodDeliveryApplicationUser> _userManager;
        private readonly SignInManager<FoodDeliveryApplicationUser> _signInManager;

        public AddressModel(UserManager<FoodDeliveryApplicationUser> userManager,
                            SignInManager<FoodDeliveryApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData] public string? StatusMessage { get; set; }

        public string? CurrentAddress { get; set; }

        [BindProperty]
        public InputModel Input { get; set; } = new();

        public class InputModel
        {
            [Required]
            [Display(Name = "Delivery address")]
            public string Address { get; set; } = string.Empty;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound("User not found.");

            CurrentAddress = user.Address;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            var user = await _userManager.GetUserAsync(User);
            if (user == null) return NotFound("User not found.");

            user.Address = Input.Address;

            var result = await _userManager.UpdateAsync(user);
            if (!result.Succeeded)
            {
                foreach (var e in result.Errors)
                    ModelState.AddModelError(string.Empty, e.Description);
                return Page();
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Delivery address updated.";
            return RedirectToPage();
        }
    }
}
