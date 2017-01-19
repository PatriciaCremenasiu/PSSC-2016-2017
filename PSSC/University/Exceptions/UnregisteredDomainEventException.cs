using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Exceptions
{
    public class UnregisteredDomainEventException : Exception
    {
        public UnregisteredDomainEventException(string message) : base(message) { }
    }
}