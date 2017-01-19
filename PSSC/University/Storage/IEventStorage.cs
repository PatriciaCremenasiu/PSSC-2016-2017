using System;
using System.Collections.Generic;
using University.Events;
using University.Models;
using University.Models.Context.Deanship;

namespace University.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T : BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
