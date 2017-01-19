using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Generics.ValueObjects;
using Models.Common.Subject;
using Models.Common.Professor;
using Models.Common.Student;
using System.Diagnostics.Contracts;

namespace University.Commands
{
    public class DefineSubjectCommand : Command
    {
        public PlainText subjectName { get; set; }
        private HashSet<DefinedSubject> _definedSubjects;

        public DefineSubjectCommand(Guid id, int version) : base(id, version)
        {
        }

        public Credits credits { get; set; }
        public EvaluationType type { get; set; }
        public Professor professor { get; set; }
        public Proportion prop{ get; set; }

        public Dictionary<Student, ViewableSituation> enrolledStudents { get; set; }

        public void DefineSubject()
        {
            
            Contract.Requires(professor != null, "Professor is null!");
            Contract.Requires(enrolledStudents != null, "Enrolled students list is null!");

            _definedSubjects.Add(new DefinedSubject(subjectName, credits, type, professor, enrolledStudents));
        }

    }
}