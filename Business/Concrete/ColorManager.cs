using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }


        public IDataResult<List<Color>> GetAll()
        {
            var result = _colorDal.GetAll();
            if (result.Count == 0)
            {
                return new ErrorDataResult<List<Color>>(ColorMessages.NotListed);
            }

            return new SuccessDataResult<List<Color>>(result, ColorMessages.Listed);
        }

        public IDataResult<Color> GetById(int id)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(c => c.Id == id),ColorMessages.Listed);
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(UserMessages.Added);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult(UserMessages.Deleted);
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult(UserMessages.Updated);
        }
    }
}
