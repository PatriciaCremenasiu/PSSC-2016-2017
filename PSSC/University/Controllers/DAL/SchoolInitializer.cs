using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Models;

namespace University.DAL
{
   public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();
            var subjects = new List<Subject>
            {
            new Subject{SubjectID=1050,Title="Chemistry",Credits=3,},
            new Subject{SubjectID=4022,Title="Microeconomics",Credits=3,},
            new Subject{SubjectID=4041,Title="Macroeconomics",Credits=3,},
            new Subject{SubjectID=1045,Title="Calculus",Credits=4,},
            new Subject{SubjectID=3141,Title="Trigonometry",Credits=4,},
            new Subject{SubjectID=2021,Title="Composition",Credits=3,},
            new Subject{SubjectID=2042,Title="Literature",Credits=4,}
            };
            subjects.ForEach(s => context.Subjects.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,SubjectID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,SubjectID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,SubjectID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,SubjectID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,SubjectID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,SubjectID=1050},
            new Enrollment{StudentID=4,SubjectID=1050,},
            new Enrollment{StudentID=4,SubjectID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,SubjectID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,SubjectID=1045},
            new Enrollment{StudentID=7,SubjectID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}