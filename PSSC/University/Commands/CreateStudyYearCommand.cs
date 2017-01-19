using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Commands
{
    public class CreateStudyYearCommand : Command
    {
        public HashSet<DefinedSubject> _definedSubjects;

        public CreateStudyYearCommand(Guid id, HashSet<DefinedSubject> definedSubjects, int version)
            : base(id, version)
        {
            _definedSubjects = definedSubjects;
        }

    }
}