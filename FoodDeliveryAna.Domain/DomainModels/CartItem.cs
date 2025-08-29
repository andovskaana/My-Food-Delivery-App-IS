using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class CartItem : BaseEntity
    {
        public Guid MenuItemId { get; set; }
        public virtual MenuItem? MenuItem { get; set; }
        [Range(1, 100)] public int Quantity { get; set; } = 1;
        public Guid ShoppingCartId { get; set; }
        public virtual ShoppingCart? ShoppingCart { get; set; }
    }
}
