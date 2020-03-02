using BlazorBoilerplate.Shared.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int OrderNo { get; set; }
        public DateTime CreationTime { get; set; }
        public decimal Total { get; set; }
        public OrderStatus OrderStatus  { get; set; }
        public int CargoId { get; set; }
        public int PaymentId { get; set; }        
        public Guid? ApplicationUserId { get; set; }

        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; }
        [ForeignKey("CargoId")]
        public virtual Cargo Cargo { get; set; }
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public Order()
        {
            CreationTime = DateTime.Now;
            OrderProducts = new HashSet<OrderProduct>();
        }
    
    }
}
