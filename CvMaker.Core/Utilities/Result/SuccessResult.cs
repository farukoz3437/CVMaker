using System;
using System.Collections.Generic;
using System.Text;

namespace CvMaker.Core.Utilities.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(success: true, message)
        {
        }

        public SuccessResult() : base(success: true)
        {

        }
    }
}
