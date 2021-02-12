using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)//this bu tek parametreliyi çalıştır
        {
            Message = message;//aşağıdaki Message 
            //Success = success;
        }
        public Result(bool success)//message olmadığında
        { 
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
