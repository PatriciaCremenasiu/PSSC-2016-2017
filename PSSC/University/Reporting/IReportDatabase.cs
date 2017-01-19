using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using University.Reporting;

namespace University.EventHandlers
{
    public interface IReportDatabase
    {
        StudyYearDto GetById(Guid id);
        void Add(StudyYearDto item);
        void Delete(Guid id);
        List<StudyYearDto> GetItems();
        void Add(SubjectDto item);
        void Add(StudentDto item);
    }
}