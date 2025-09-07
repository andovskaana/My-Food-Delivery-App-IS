using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class MenuItem : BaseEntity
    {
        [Required] public string Name { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }

        public Guid MenuId { get; set; }
        public virtual Menu? Menu { get; set; }
    }
}
