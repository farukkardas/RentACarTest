using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;

namespace DataAccess.Concrete
{
   public class EfUserDal:EfEntityRepositoryBase<User,CarRentContext>,IUserDal
    {
    }
}
