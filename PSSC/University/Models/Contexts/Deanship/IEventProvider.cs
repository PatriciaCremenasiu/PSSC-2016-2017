using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Events;

namespace University.Models
{
    public interface IEventProvider
    {
        void LoadsFromHistory(IEnumerable<Event> history);
        IEnumerable<Event> GetUncommittedChanges();
    }
}
