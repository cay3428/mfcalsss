using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //private bool v1;
        //private string v2;


        public Result(bool success, string message) : this (success )
        {
            Success =success;

            Message = message;

            //this.v1 = v1;
            //this.v2 = v2;
        }

        public Result (bool success)
        {

            Success = success;

        }


        public bool Success { get; }

        public string Message { get; }
    }
}
