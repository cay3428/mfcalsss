using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public  class ErrorDataResult <T> : DataResult<T> 
    {
        //public List<global::varlıksss.cerezz.Product> MaintenceTime { get; }

        public ErrorDataResult(T data, string message) : base(data, true, message)
        {

        }

        public ErrorDataResult(T data) : base(data, true)
        {


        }
        public ErrorDataResult(string message) : base(default, true, message)
        {

        }

        public ErrorDataResult() : base(default, true)
        {

        }

        //public ErrorDataResult(List<global::varlıksss.cerezz.Product> maintenceTime)
        //{
        //    MaintenceTime = maintenceTime;
        //}
    }
}
