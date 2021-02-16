using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Core.Entities;

namespace Entities.Dto
{
    public class RentalDetailDto:IDto
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarName { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }

    }
}
