using Models.Contexts.Deanship;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using Models.Common.Subject;
using Models.Common.Professor;
using University.Models;

namespace University.Commands
{
    public class EnrollStudentToSubjectCommand : Command
    {
        public HashSet<DefinedSubject> _definedSubjects;
        internal ViewableSituation credits;
        internal object professor;
        internal Professor situation;
        internal Credits subjectName;

        public EnrollStudentToSubjectCommand(Guid id, int version) : base(id, version)
        {
        }
        public void EnrollStudentToSubject(PlainText subjectName, Student student)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(student != null, "Student is null!");

            _definedSubjects.First(d => d.Name == subjectName).EnrollStudent(student);
        }
    }
}