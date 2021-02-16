using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Dto
{
    public class CustomerDetailDto:IDto
    {
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
