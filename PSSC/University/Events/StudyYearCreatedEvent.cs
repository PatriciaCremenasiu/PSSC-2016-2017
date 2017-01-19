using System;
using System.Collections.Generic;
using University.Events;

namespace Models.Contexts.Deanship
{
    public class StudyYearCreatedEvent : Event
    {
        public HashSet<DefinedSubject> definedSubjects { set; get; }
        public Guid id { set; get; }

        public StudyYearCreatedEvent(Guid id, HashSet<DefinedSubject> definedSubjects)
        {
            this.id = id;
            this.definedSubjects = definedSubjects;
        }
    }
}