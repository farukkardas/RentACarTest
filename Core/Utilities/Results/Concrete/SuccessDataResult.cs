using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Abstract;

namespace Core.Utilities.Results.Concrete
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        public SuccessDataResult(T data, bool success, string message) : base(data, success, message)
        {
        }

        public SuccessDataResult(T data, bool success) : base(data, success)
        {
        }

        public SuccessDataResult(string message) : base(default, true, message)
        {

        }

        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
    