using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities;

namespace Business.Concrete
{
    public class UserManager:IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            if (_userDal.GetAll().Count == 0)
            {
                return new ErrorDataResult<List<User>>(UserMessages.NotListed);
            }

            return new SuccessDataResult<List<User>>(result);
        }

        public IDataResult<User> GetById(int id)
        {
            var result = _userDal.Get(p => p.Id == id);
            return new SuccessDataResult<User>(result,UserMessages.Listed);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(UserMessages.Added);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(UserMessages.Deleted);
            
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(UserMessages.Updated);
        }
    }
}
