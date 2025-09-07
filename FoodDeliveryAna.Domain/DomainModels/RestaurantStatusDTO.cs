using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryAna.Domain.DomainModels
{
    public class RestaurantStatusDTO
    {
        public string RestaurantName { get; init; } = "";
        public string RestaurantSlug { get; init; } = "";
        public bool IsOpen { get; init; }
        public string? TodayRange { get; init; }
        public double? Rating { get; init; }
    }

}
