using System;
using System.Collections.Generic;
using System.Text;


namespace Exceptions
{
    class WeightException : Exception
    {
        public WeightException(string message) : base(message)
        {
        }
    }
}
