using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.Dto;

namespace DataAccess.Concrete
{
   public class EfCarDal:EfEntityRepositoryBase<Car,CarRentContext>,ICarDal
    {
        public List<CarDetailDto> GetAllCarDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Cars
                    join b in context.Brands on c.BrandId equals b.Id
                    join g in context.Colors on c.ColorId equals g.Id
                    select new CarDetailDto()
                    {
                        CarName = c.CarName,
                        DailyPrice = c.DailyPrice,
                        BrandName = b.BrandName,
                        ColorName = g.ColorName
                    };
                return result.ToList();
            }
        }

      
    }
}
