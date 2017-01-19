using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Reporting;

namespace University.EventHandlers
{
    public class StudentAddedEventHandler : IEventHandler<StudentAddedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public StudentAddedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }

        void IEventHandler<StudentAddedEvent>.Handle(StudentAddedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            regNumber = handle.regNumber;
            name = handle.name;
        }
    }
}