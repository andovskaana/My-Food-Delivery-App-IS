using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class Restaurant : BaseEntity
    {
        [Required, MaxLength(120)] public string Name { get; set; } = string.Empty;
        [MaxLength(2000)] public string? Description { get; set; }
        public string? City { get; set; }
        public string? StreetAddress { get; set; }
        public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();

        /// <summary>
        /// Optional opening hours information for the restaurant. This can
        /// contain human‑readable business hours (e.g. "Mon–Fri 08:00–22:00, Sat–Sun 09:00–23:00").
        /// Because we are not calling a remote API at runtime, this value is
        /// typically set when seeding the database.
        /// </summary>
        [MaxLength(2000)]
        public string? OpeningHours { get; set; }

        /// <summary>
        /// Average customer rating for the restaurant on a scale of 0 to 5.
        /// This field is nullable because not all restaurants may have ratings.
        /// When seeding initial data we will populate this with values taken
        /// from publicly available listings.
        /// </summary>
        [Range(0, 5)]
        public decimal? Rating { get; set; }

        /// <summary>
        /// Latitude coordinate of the restaurant.  This can be used to
        /// display a marker on a map or calculate distances.  If not
        /// specified the value will be null.
        /// </summary>
        public double? Latitude { get; set; }

        /// <summary>
        /// Longitude coordinate of the restaurant.  See <see cref="Latitude"/> for details.
        /// </summary>
        public double? Longitude { get; set; }
    }
}
