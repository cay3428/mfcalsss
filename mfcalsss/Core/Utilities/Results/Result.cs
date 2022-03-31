using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool Success => throw new NotImplementedException();

        public string Message => throw new NotImplementedException();
    }
}
