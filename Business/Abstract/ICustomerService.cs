using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;
using Core.Utilities.Results;
using Entities;
using Entities.Dto;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<CustomerDetailDto>> GetAllCustomerDetails();
        IDataResult<Customer> GetById(int id);
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
    }
}
