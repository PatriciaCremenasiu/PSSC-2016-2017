using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Exceptions
{
    public class ConcurrencyException: Exception 
    {
        public ConcurrencyException(string message) : base(message) { }
}
}