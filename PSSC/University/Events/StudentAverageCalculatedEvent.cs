using System;
using Models.Generics.ValueObjects;
using University.Events;

namespace Models.Contexts.Deanship
{
    internal class StudentAverageCalculatedEvent : Event
    {
        internal object name;
        private Guid id;
        private RegistrationNumber regNumber;
        private PlainText subjectName;

        public StudentAverageCalculatedEvent(Guid id, PlainText subjectName, RegistrationNumber regNumber)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.regNumber = regNumber;
        }
    }
}