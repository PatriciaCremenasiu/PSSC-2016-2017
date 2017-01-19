using Models.Common.Subject;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace University.Reporting
{
    public class SubjectDto
    {
        [Required]
        public Credits credits { set; get; }

        [Required]
        public Dictionary<Models.Common.Student.Student, ViewableSituation> enrolledStudents { set; get; }

        [Required]
        public Models.Common.Professor.Professor professor { set; get; }

        [Required]
        public Proportion prop { set; get; }

        [Required]
        public PlainText subjectName { set; get; }

        [Required]
        public EvaluationType type { set; get; }

       
    }
}