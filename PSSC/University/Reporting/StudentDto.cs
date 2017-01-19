using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace University.Reporting
{
    public class StudentDto
    {
        [Required]
        public Guid id { get; set; }

        [Required]
        public PlainText name { get; set; }

        [Required]
        public RegistrationNumber regNumber { get; set; }
    }
}