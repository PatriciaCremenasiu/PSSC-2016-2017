using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Models;
using University.Events;
using University.Exceptions;
using University.Messaging;
using University.Storage.Memento;
using University.Utilis;
using University.Models.Context.Deanship;

namespace University.Storage
{
    public class InMemoryEventStorage : IEventStorage
    {
        private List<Event> _events;
        private List<Models.Context.Deanship.BaseMemento> _mementos;

        private readonly IEventBus _eventBus;

        public InMemoryEventStorage(IEventBus eventBus)
        {
            _events = new List<Event>();
            _mementos = new List<Models.Context.Deanship.BaseMemento>();
            _eventBus = eventBus;
        }

        public IEnumerable<Event> GetEvents(Guid aggregateId)
        {
            var events = _events.Where(p => p.AggregateId == aggregateId).Select(p => p);
            if (events.Count() == 0)
            {
                throw new AggregateNotFoundException(string.Format("Aggregate with Id: {0} was not found", aggregateId));
            }
            return events;
        }

        public void Save(AggregateRoot aggregate)
        {
            var uncommittedChanges = aggregate.GetUncommittedChanges();
            var version = aggregate.Version;

            foreach (var @event in uncommittedChanges)
            {
                version++;
                if (version > 2)
                {
                    if (version % 3 == 0)
                    {
                        var originator = (IOriginator)aggregate;
                        var memento = originator.GetMemento();
                        memento.Version = version;
                        SaveMemento(memento);
                    }
                }
                @event.Version = version;
                _events.Add(@event);
            }
            foreach (var @event in uncommittedChanges)
            {
                var desEvent = Converter.ChangeTo(@event, @event.GetType());
                _eventBus.Publish(desEvent);
            }
        }

        private void SaveMemento(Memento.BaseMemento memento)
        {
            throw new NotImplementedException();
        }

        public T GetMemento<T>(Guid aggregateId) where T : Models.Context.Deanship.BaseMemento
        {
            var memento = _mementos.Where(m => m.Id == aggregateId).Select(m => m).LastOrDefault();
            if (memento != null)
                return (T)memento;
            return null;
        }

        public void SaveMemento(Models.Context.Deanship.BaseMemento memento)
        {
            _mementos.Add(memento);
        }

        
    }
}
