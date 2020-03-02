using BlazorBoilerplate.Shared.Dto;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorBoilerplate.Server.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        [MaxLength(64)]
        public string FirstName { get; set; }

        [MaxLength(64)]
        public string LastName { get; set; }

        [MaxLength(64)]
        public string FullName { get; set; }

        public ICollection<ApiLogItem> ApiLogItems { get; set; }

        public UserProfile Profile { get; set; }

        public virtual ICollection<Message> Messages { get; set; }
 
        public int? UserAddressId { get; set; }
        [ForeignKey("UserAddressId")]
        public virtual UserAddress UserAddress{ get; set; }
        public virtual ICollection<Order> Orders { get; set; }       
    }
}
