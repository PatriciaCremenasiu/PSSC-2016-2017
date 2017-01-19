using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Common.Subject;
using Models.Generics.ValueObjects;
using University.EventHandlers;
using Models.Contexts.Deanship;

namespace University.Reporting
{
    public class ReportDatabase : IReportDatabase
    {
        static List<StudyYearDto> items = new List<StudyYearDto>();

        public void Add(StudentDto item)
        {
            throw new NotImplementedException();
        }

        public void Add(SubjectDto item)
        {
            throw new NotImplementedException();
        }

        public StudyYearDto GetById(Guid id)
        {
            return items.Where(a => a.Id == id).FirstOrDefault();
        }

        void IReportDatabase.Add(StudyYearDto item)
        {
            items.Add(item);
        }

        void IReportDatabase.Delete(Guid id)
        {
            items.RemoveAll(i => i.Id == id);
        }

        List<StudyYearDto> IReportDatabase.GetItems()
        {
            return items;
        }
    }
}