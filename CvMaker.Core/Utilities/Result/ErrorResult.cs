using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Core.Utilities.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(string message) : base(success: false, message)
        {

        }
        public ErrorResult() : base(success: false)
        {

        }
    }
}
