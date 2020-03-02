using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto
{ 
    public enum OrderStatus
    {
        OrderWasPlaced = 0,
        Shipped = 1,
        Delivered = 2,
    }
}
