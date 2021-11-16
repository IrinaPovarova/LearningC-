using System;
using System.Collections.Generic;
using System.Text;


namespace Exceptions
{
    class IntervalException : Exception
    {
        public IntervalException(string message) : base(message)
        {
        }
    }
}
