using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Events;

namespace University.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}
