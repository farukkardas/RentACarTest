using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Core.Entities;

namespace Entities
{
   public class Customer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
    }
}
