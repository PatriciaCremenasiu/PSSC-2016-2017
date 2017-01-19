using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Reporting;

namespace University.EventHandlers
{
    public class SubjectSituationShowedEventHandler : IEventHandler<SubjectSituationShowedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public SubjectSituationShowedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }

        void IEventHandler<SubjectSituationShowedEvent>.Handle(SubjectSituationShowedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            credits = handle.credits;
            enrolledStudents = handle.enrolledStudents;
            professor = handle.professor;
            prop = handle.prop;
            subjectName = handle.subjectName;
            type = handle.type;
           
        }
    }
}