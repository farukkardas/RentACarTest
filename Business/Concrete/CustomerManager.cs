using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities;
using Entities.Dto;

namespace Business.Concrete
{
    public class CustomerManager:ICustomerService
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var result = _customerDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<Customer>>(CustomerMessages.NotListed);
            }

            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), CustomerMessages.Listed);
        }

     

        public IDataResult<List<CustomerDetailDto>> GetAllCustomerDetails()
        {
            var result = _customerDal.GetAllCustomerDetails();
            return new SuccessDataResult<List<CustomerDetailDto>>(result, CustomerMessages.Listed);
        }

        public IDataResult<Customer> GetById(int id)
        {
            var result = _customerDal.Get(p => p.Id == id);
            return new SuccessDataResult<Customer>(result, CustomerMessages.Listed);
        }
        [ValidationAspect(typeof(BrandValidator))]
        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(CustomerMessages.Added);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(CustomerMessages.Deleted);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(CustomerMessages.Updated);
        }
    }
}
