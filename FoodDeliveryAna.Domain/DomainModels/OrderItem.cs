using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class OrderItem : BaseEntity
    {
        public Guid MenuItemId { get; set; }
        public string MenuItemName { get; set; } = string.Empty; // snapshot
        [Column(TypeName = "decimal(18,2)")]  public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Guid OrderId { get; set; }
        public virtual Order? Order { get; set; }
    }
}
