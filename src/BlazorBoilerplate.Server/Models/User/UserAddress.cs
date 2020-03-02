using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Models
{
    public class UserAddress        
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }        
        public int StateId { get; set; }
        [ForeignKey("StateId")]
        public virtual State State { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public string Telephone { get; set; }
        public Guid? ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

    }
}
