using Models.Contexts.Deanship;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Reporting;

namespace University.EventHandlers
{
    public class SubjectDefinedEventHandler : IEventHandler<SubjectDefinedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public SubjectDefinedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }

        void IEventHandler<SubjectDefinedEvent>.Handle(SubjectDefinedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            credits = handle.credits;
            enrolledStudents = handle.enrolledStudents;
            professor = handle.professor;
            prop = handle.prop;
            subjectName = handle.subjectName;
            type = handle.type;

            _reportDatabase.Add(item);
        }
    }
}