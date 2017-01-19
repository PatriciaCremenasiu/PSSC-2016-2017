using System;
using Models.Common.Student;
using Models.Generics.ValueObjects;
using University.Events;

namespace Models.Contexts.Deanship
{
    internal class StudentEnrolledToSubjectEvent : Event
    {
        private Guid id;
        private Common.Student.Student student;
        private PlainText subjectName;

        public StudentEnrolledToSubjectEvent(Guid id, PlainText subjectName, Common.Student.Student student)
        {
            this.id = id;
            this.subjectName = subjectName;
            this.student = student;
        }
    }
}