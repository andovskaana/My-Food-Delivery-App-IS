using System;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodDeliveryAna.Domain.DomainModels;


namespace FoodDeliveryAna.Domain.Identity
{
    public class FoodDeliveryApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? Address { get; set; }
        public virtual ShoppingCart? ShoppingCart { get; set; }
    }
}
