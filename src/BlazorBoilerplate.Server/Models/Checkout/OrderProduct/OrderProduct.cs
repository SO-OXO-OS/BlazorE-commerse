using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Models
{
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("ProductId")]        
        public virtual Product Product { get; set; }
        [ForeignKey("OrderId")]        
        public virtual Order Order { get; set; }
        public int Quantity { get; set; }
    }
}
