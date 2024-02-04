using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSuccess,string message):this(isSuccess)
        {
            
            Message = message;
        }
        public Result(bool isSuccess)
        {
            IsSucces = isSuccess;
        }
        public bool IsSucces { get; }

        public string Message { get; }
    }
}
