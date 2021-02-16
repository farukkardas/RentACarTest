using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities;
using Entities.Dto;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var result = _rentalDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<Rental>>(RentalMessages.NotListed);
            }

            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),RentalMessages.Listed);
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            var result = _rentalDal.GetAllRentalDetails();
            return new SuccessDataResult<List<RentalDetailDto>>(result, RentalMessages.Listed);
        }

        public IDataResult<Rental> GetById(int id)
        {
            var result = _rentalDal.Get(p => p.Id == id);
            return new SuccessDataResult<Rental>(result, RentalMessages.Listed);
        }

        public IResult Add(Rental rental)
        {
            _rentalDal.Add(rental);
            return new SuccessResult(RentalMessages.Added);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(RentalMessages.Deleted);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(RentalMessages.Updated);
        }
    }
}
