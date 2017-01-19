using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
    /*
     * Basic subject situation which describes a student's grades
     * Has 2 implementations:
     * 1. ViewableSituation (Unmodifiable / Readonly - Used in the Deanship and Student context)
     * 2. GradableSituation (Used in the Professor context)
     */
    public abstract class SubjectSituation : Entity<RegistrationNumber> //Guid? 
    {
        protected List<Attendance> _attendances { get; set; }
        protected List<Grade> _examGrades { get; set; }
        protected List<Grade> _activityGrades { get; set; }

        public SubjectSituation(RegistrationNumber regNumber) : base(regNumber)
        {
            _attendances = new List<Attendance>();
            _examGrades = new List<Grade>();
            _activityGrades = new List<Grade>();
        }

        public SubjectSituation(RegistrationNumber regNumber, List<Attendance> attendances, List<Grade> examGrades, List<Grade> activityGrade)
            : base(regNumber)
        {
            Contract.Requires(_attendances != null, "Attendance list is null!");
            Contract.Requires(_examGrades != null, "Exam grades list is null!");
            Contract.Requires(_activityGrades != null, "Activity grades list is null!");

            _attendances = attendances;
            _examGrades = examGrades;
            _activityGrades = activityGrade;
        }

        public Grade GetActivityAverage()
        {
            Grade average;

            average = new Grade(_activityGrades.Aggregate(0.0m, (acc, curr) => acc + curr.Value) / _activityGrades.Count);

            return average;
        }

        public Grade GetExamAverage()
        {
            Grade average;
            
            average = new Grade(_examGrades.Aggregate(0.0m, (acc, curr) => acc + curr.Value) / _examGrades.Count);

            return average;
        }
    }
}
