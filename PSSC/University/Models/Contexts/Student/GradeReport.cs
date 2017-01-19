using Models.Common.Subject;
using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Student
{
    /*
     * Aggregate root
     * Student interacts with a set of Subjects to which he has enrolled ('EnrolledSubject')
     * He is only able to retrieve his 'SubjectSituation' for any 'EnrolledSubject'
     */
    public class GradeReport : Entity<RegistrationNumber>
    {
        private HashSet<EnrolledSubject> _gradeReport { get; set; }

        public GradeReport(RegistrationNumber id, HashSet<EnrolledSubject> gradeReport) : base(id)
        {
            Contract.Requires(gradeReport != null, "Grade report is null!");

            _gradeReport = gradeReport;
        }

        public ViewableSituation GetSubjectSituation(PlainText subjectName)
        {
            ViewableSituation situation;

            situation = _gradeReport.First(d => d.Name == subjectName).Situation;

            return situation;
        }
    }
}