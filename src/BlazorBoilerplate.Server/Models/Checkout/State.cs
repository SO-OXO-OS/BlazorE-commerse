using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBoilerplate.Server.Models
{
    public class State
    {        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
