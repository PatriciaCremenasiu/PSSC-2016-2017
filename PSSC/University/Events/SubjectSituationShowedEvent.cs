using System;
using Models.Common.Subject;
using Models.Generics.ValueObjects;
using University.Events;

namespace Models.Contexts.Deanship
{
    internal class SubjectSituationShowedEvent : Event
    {
        internal readonly System.Collections.Generic.Dictionary<University.Models.Common.Student.Student, ViewableSituation> enrolledStudents;
        internal readonly University.Models.Common.Professor.Professor professor;
        internal readonly Proportion prop;
        internal EvaluationType type;
        private Guid id;
        private RegistrationNumber regNumber;
        private PlainText subjectName;

        public SubjectSituationShowedEvent(Guid id, PlainText subjectName, RegistrationNumber regNumber)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.regNumber = regNumber;
        }

        public Credits credits { get; internal set; }
    }
}