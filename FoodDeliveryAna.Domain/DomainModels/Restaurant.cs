using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class Restaurant : BaseEntity
    {
        [Required, MaxLength(120)] public string Name { get; set; } = string.Empty;
        [MaxLength(2000)] public string? Description { get; set; }
        public string? City { get; set; }
        public string? StreetAddress { get; set; }

        public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

        [MaxLength(2000)] public string? OpeningHours { get; set; }
        [Range(0, 5)] public decimal? Rating { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public string? ImageUrl { get; set; }   
        public string? Category { get; set; }   
        public int? DeliveryPrice { get; set; } 
    }
}