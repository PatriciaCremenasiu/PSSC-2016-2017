using System;
using University.Events;

namespace Models.Contexts.Deanship
{
    public class StudyYearDeletedEvent : Event
    {
        public StudyYearDeletedEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}