using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}