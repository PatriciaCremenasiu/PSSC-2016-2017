using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Exceptions
{
    public class AggregateNotFoundException : Exception
    {
        public AggregateNotFoundException(string message) : base(message) { }
    }
}