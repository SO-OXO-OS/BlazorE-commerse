using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto
{
    public class BasketModel
    {
        public int Quantity { get; set; }
        public ProductDto Product { get; set; }
    }
}
