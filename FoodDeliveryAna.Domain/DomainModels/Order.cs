using FoodDeliveryAna.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        public string OwnerId { get; set; } = string.Empty;
        public virtual FoodDeliveryApplicationUser? Owner { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column(TypeName = "decimal(18,2)")]  public decimal Total { get; set; }
        public virtual ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
