using System;

namespace BlazorBoilerplate.Shared.Dto
{
    public class CreateOrderDto
    {
        public int OrderNo { get; set; }
        public int CargoId { get; set; }
        public int PaymentId { get; set; }
        public int CountryId { get; set; }
        public int StateId { get; set; }
        public Guid? ApplicationUserId { get; set; }        
        public OrderStatus OrderStatus { get; set; }
        public int UserAddressId { get; set; }        
        public decimal Total { get; set; }
    }

}
