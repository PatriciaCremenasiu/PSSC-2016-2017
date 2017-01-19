using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Professor
{
    /*
     * SubjectSituation implementation
     */
    public class GradeableSituation : SubjectSituation
    {
        public List<Attendance> Attendances { get { return _attendances; } set { _attendances = value; } }
        public List<Grade> ExamGrades { get { return _examGrades; } set { _examGrades = value; } }
        public List<Grade> ActivityGrades { get { return _activityGrades; } set { _activityGrades = value; } }

        public GradeableSituation(RegistrationNumber regNumber, List<Attendance> att, List<Grade> examGrades, List<Grade> activityGrades)
            : base(regNumber, att, examGrades, activityGrades)
        {
            
        }
    }
}
