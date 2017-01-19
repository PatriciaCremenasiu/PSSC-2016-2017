using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.EventHandlers
{
    public class StudyYearCreatedEventHandler : IEventHandler<StudyYearCreatedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public StudyYearCreatedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(StudyYearCreatedEvent handle)
        {
            StudyYearDto item = new StudyYearDto()
            {
                Id = handle.AggregateId,

                _definedSubjects = handle.definedSubjects,
                Version = handle.Version
            };

            _reportDatabase.Add(item);
        }
    }
}