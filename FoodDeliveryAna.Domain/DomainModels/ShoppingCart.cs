using FoodDeliveryAna.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class ShoppingCart : BaseEntity
    {
        public string OwnerId { get; set; } = string.Empty;
        public virtual FoodDeliveryApplicationUser? Owner { get; set; }
        public virtual ICollection<CartItem> Items { get; set; } = new List<CartItem>();
    }

}
