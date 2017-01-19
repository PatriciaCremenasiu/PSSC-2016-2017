using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.EventHandlers
{
    public class StudyYearDeletedEventHandler : IEventHandler<StudyYearDeletedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public StudyYearDeletedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(StudyYearDeletedEvent handle)
        {
            _reportDatabase.Delete(handle.AggregateId);
        }
    }
}