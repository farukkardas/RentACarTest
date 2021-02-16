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
    public class EfCustomerDal:EfEntityRepositoryBase<Customer,CarRentContext>,ICustomerDal
    {
        public List<CustomerDetailDto> GetAllCustomerDetails()
        {
            using (CarRentContext context = new CarRentContext())
            {
                var result = from c in context.Customers
                    join u in context.Users
                        on c.UserId equals u.Id
                    select new CustomerDetailDto
                    {
                        CompanyName = c.CustomerName,
                        Email = u.Email,
                        Password = u.Password
                    };
                return result.ToList();
            }
        }
    }
}
