using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;

namespace FoodDeliveryAna.Web.Controllers
{
    public record CreateIntentRequest(long AmountCents, string? Currency);
    public record CreateIntentResponse(string clientSecret, string publishableKey);

    [ApiController]
    [Route("api/payment")]
    public class PaymentController : ControllerBase
    {
        private readonly StripeSettings _stripe;
        public PaymentController(IOptions<StripeSettings> stripe) => _stripe = stripe.Value;

        [HttpPost("create-intent")]
        public async Task<ActionResult<CreateIntentResponse>> CreateIntent([FromBody] CreateIntentRequest req)
        {
            StripeConfiguration.ApiKey = _stripe.SecretKey;

            var options = new PaymentIntentCreateOptions
            {
                Amount = req.AmountCents,                        // cents
                Currency = string.IsNullOrWhiteSpace(req.Currency) ? "usd" : req.Currency,
                PaymentMethodTypes = new List<string> { "card" },
                Metadata = new Dictionary<string, string> { ["source"] = "FoodDeliveryAna" }
            };

            var service = new PaymentIntentService();
            var intent = await service.CreateAsync(options);

            return new CreateIntentResponse(intent.ClientSecret!, _stripe.PublishableKey);
        }
    }
}
