﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto
{
    public class CreateProductDto
    {
        public string Name { get; set; }
        public int Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Colour { get; set; }
        public string ImgUrl { get; set; }
        public int CategoryId { get; set; }        
    }
}
