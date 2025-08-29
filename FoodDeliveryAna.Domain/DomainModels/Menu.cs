using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class Menu : BaseEntity
    {
        [Required] public string Title { get; set; } = string.Empty;
        public Guid RestaurantId { get; set; }
        public virtual Restaurant? Restaurant { get; set; }
        public virtual ICollection<MenuItem> Items { get; set; } = new List<MenuItem>();
    }
}
