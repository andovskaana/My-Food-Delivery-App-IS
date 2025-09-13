using System;

namespace FoodDeliveryAna.Domain.Enums
{
    public enum OrderStatus
    {
        Placed = 0,
        Accepted = 1,
        PickedUp = 2,
        Delivered = 3,
        Cancelled = 4
    }
}
