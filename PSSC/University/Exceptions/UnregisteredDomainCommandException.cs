using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Exceptions
{
    public class UnregisteredDomainCommandException : Exception
    {
        public UnregisteredDomainCommandException(string message) : base(message) { }
    }
}