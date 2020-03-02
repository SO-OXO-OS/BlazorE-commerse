using System;

namespace BlazorBoilerplate.Shared.Dto
{    
    public class OrdersByUserIdResultDto
    {
        public int OrderNo { get; set; }
        public decimal Total { get; set; }
        public OrderStatus OrderStatus { get; set; }   
        public DateTime CreationTime { get; set; }

    }
}
