using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Reporting;

namespace University.EventHandlers
{
    public class StudentAverageCalculatedEventHandler : IEventHandler<StudentAverageCalculatedEvent>
    {
        private readonly IReportDatabase _reportDatabase;

        public StudentAverageCalculatedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }

        void IEventHandler<StudentAverageCalculatedEvent>.Handle(StudentAverageCalculatedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            regNumber = handle.regNumber;
            name = handle.name;

        }
    }
}