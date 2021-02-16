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
    public class CarManager:ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IDataResult<List<Car>> GetAll()
        {
            var result = _carDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<Car>>(CarMessages.CarDescriptionInvalid);
            }

            return new SuccessDataResult<List<Car>>(result, CarMessages.CarsListed);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), CarMessages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId),UserMessages.Listed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId), UserMessages.Listed);
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetails()
        {
            var result = _carDal.GetAllCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(result, CarMessages.CarsListed);
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(CarMessages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(CarMessages.CarUpdated);
        }

        public IResult Delete(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(CarMessages.CarNotDeleted);
        }
    }
}
