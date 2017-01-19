using System;
using System.Collections.Generic;
using Models.Common.Professor;
using Models.Common.Student;
using Models.Common.Subject;
using Models.Generics.ValueObjects;
using University.Events;

namespace Models.Contexts.Deanship
{
    internal class SubjectDefinedEvent : Event
    {
        public Credits credits { set; get; }
        public Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents { set; get; }
        public Guid id;
        public Common.Professor.Professor professor { set; get; }
        public Proportion prop { set; get; }
        public PlainText subjectName { set; get; }
        public EvaluationType type { set; get; }

        public SubjectDefinedEvent(Guid id, PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents, EvaluationType type, Common.Professor.Professor professor, Proportion prop)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.credits = credits;
            this.enrolledStudents = enrolledStudents;
            this.type = type;
            this.professor = professor;
            this.prop = prop;
        }
    }
}