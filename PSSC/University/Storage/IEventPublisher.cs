using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using University.Events;

namespace University.Storage
{
    public interface IEventPublisher
    {
        void Publish(Event @event);
    }
}