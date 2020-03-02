using System;
using System.Collections.Generic;

namespace BlazorBoilerplate.Shared.Dto
{
    public class GetOrderDetailByIdResultDto 
    {        
        public int Id { get; set; }
        public Guid? ApplicationUserId { get; set; }
        public UserAddressDto UserAddressDto{ get; set; }        
        public decimal Total { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string CargoName { get; set; }
        public string PaymentName { get; set; }                
        public DateTime CreationTime { get; set; }
        public List<OrderProductDto> OrderProducts { get; set; }
    }
}
