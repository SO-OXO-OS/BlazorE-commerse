using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBoilerplate.Shared.Dto
{
    public class CreateUserAddressDto
    {
        public string Address { get; set; }
        public int StateId { get; set; }
        public string Telephone { get; set; }
        public int CountryId { get; set; }
        public Guid? ApplicationUserId { get; set; }
    }
}
