using System;

namespace BlazorBoilerplate.Shared.Dto
{
    public class OrderDto
    {
        public int OrderNo { get; set; }
        public DateTime CreationTime { get; set; }
        public decimal Total { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int CargoId { get; set; }
        public int PaymentId { get; set; }
        public Guid? ApplicationUserId{ get; set; }
        public UserAddressDto UserAddress { get; set; }

    }
}
