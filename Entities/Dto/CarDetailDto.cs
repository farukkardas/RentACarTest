﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Dto
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public int Id { get; set; }
        public decimal DailyPrice { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }


    }
}
