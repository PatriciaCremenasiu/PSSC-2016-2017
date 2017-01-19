using Models.Contexts.Deanship;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace University.Commands
{
    public class CalculateStudentAverageCommand : Command
    {
        public HashSet<DefinedSubject> _definedSubjects;

        public CalculateStudentAverageCommand(Guid id, int version) : base(id, version)
        {
        }
        public Grade CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            Contract.Requires(subjectName != null, "Subject name is null!");
            Contract.Requires(regNumber != null, "Registration number is null!");

            return _definedSubjects.First(d => d.Name == subjectName).GetStudentAverage(regNumber);
        }
    }
}