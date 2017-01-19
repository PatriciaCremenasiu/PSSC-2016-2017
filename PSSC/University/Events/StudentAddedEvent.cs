using System;
using Models.Generics.ValueObjects;
using University.Events;

namespace Models.Contexts.Deanship
{
    public class StudentAddedEvent : Event
    {
        public Guid id { get; set; }
        public PlainText name { get; set; }
        public RegistrationNumber regNumber { get; set; }

        public StudentAddedEvent(Guid id, RegistrationNumber regNumber, PlainText name)
        {
            this.id = id;
            this.regNumber = regNumber;
            this.name = name;
        }
    }
}