using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Discount { get; set; }

        public decimal UnitPrice { get; set; }

        public short UnitsInStock { get; set; }
        public string ImgUrl { get; set; }        
        public string ColourName { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }        
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
        }
    }
}
