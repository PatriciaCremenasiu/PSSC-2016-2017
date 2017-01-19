using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Subject
{
    /*
     * Entity which describes a students subject situation
     * Readonly entity - unable to propagate modifications
     */
    public class ViewableSituation : SubjectSituation
    {
        public ReadOnlyCollection<Attendance> Attendances { get { return _attendances.AsReadOnly(); } }
        public ReadOnlyCollection<Grade> ExamGrades { get { return _examGrades.AsReadOnly(); } }
        public ReadOnlyCollection<Grade> ActivityGrades { get { return _activityGrades.AsReadOnly(); } }

        public ViewableSituation(RegistrationNumber regNumber) : base(regNumber)
        {

        }

        public ViewableSituation(RegistrationNumber regNumber, List<Attendance> att, List<Grade> examGrades, List<Grade> activityGrades) 
            : base(regNumber, att, examGrades, activityGrades)
        {

        }
    }
}
