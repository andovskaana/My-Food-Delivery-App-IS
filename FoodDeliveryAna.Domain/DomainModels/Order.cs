using FoodDeliveryAna.Domain.Identity;
using FoodDeliveryAna.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class Order : BaseEntity
    {
        [Required]
        public string OwnerId { get; set; } = string.Empty;
        public virtual FoodDeliveryApplicationUser? Owner { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public virtual ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

        // --- Added for role-based flows ---
        public OrderStatus Status { get; set; } = OrderStatus.Placed;

        // Courier assigned to this order (nullable until accepted)
        public string? CourierId { get; set; }
        public virtual FoodDeliveryApplicationUser? Courier { get; set; }

        // Basic delivery tracking
        [MaxLength(256)]
        public string? DeliveryAddress { get; set; }
        public DateTime? AcceptedAt { get; set; }
        public DateTime? PickedUpAt { get; set; }
        public DateTime? DeliveredAt { get; set; }
    }
}
