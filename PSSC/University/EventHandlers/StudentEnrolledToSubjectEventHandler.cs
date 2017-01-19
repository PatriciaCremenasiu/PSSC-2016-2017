using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Reporting;

namespace University.EventHandlers
{
    public class StudentEnrolledToSubjectEventHandler : IEventHandler<StudentEnrolledToSubjectEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public StudentEnrolledToSubjectEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }

        void IEventHandler<StudentEnrolledToSubjectEvent>.Handle(StudentEnrolledToSubjectEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            regNumber = handle.regNumber;
            name = handle.name;
         }
    }
}