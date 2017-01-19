using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Professor
{
    /*
     * Entity
     * A TeachingSubject is a class which describes:
     * 1. All the enrolled students for the current subject, along with their subject situation
     * 2. The activity proportion
     */
    public class TeachingSubject : Subject
    {
        private Dictionary<Common.Student.Student, GradeableSituation> _enrolledStudents { get; set; }

        public Proportion ActivityProportion { get; internal set; }

        public TeachingSubject(Dictionary<Common.Student.Student, GradeableSituation> enrolledStudents, PlainText subjectName, Credits credits)
            : base(subjectName, credits)
        {
            Contract.Requires(enrolledStudents != null, "Enrolled students list is null!");

            _enrolledStudents = enrolledStudents;
        }
        
        public void AddExamGrade(RegistrationNumber regNumber, Grade grade)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.ExamGrades.Add(grade);
        }

        public void AddActivityGrade(RegistrationNumber regNumber, Grade grade)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.ActivityGrades.Add(grade);
        }

        public void AddAttendance(RegistrationNumber regNumber, Attendance attendance)
        {
            _enrolledStudents.First(d => d.Key.RegNumber == regNumber)
                .Value.Attendances.Add(attendance);
        }

        public void ModifyExamGrade(RegistrationNumber regNumber, Grade grade)
        {
            Common.Student.Student key = _enrolledStudents.First(d => d.Key.RegNumber == regNumber).Key;
            int index = _enrolledStudents[key].ExamGrades.FindIndex(d => d.Date.Equals(grade.Date));

            _enrolledStudents[key].ExamGrades[index] = grade;
        }

        public void SetActivityProportion(Proportion proportion)
        {
            ActivityProportion = proportion;
        }
    }
}
