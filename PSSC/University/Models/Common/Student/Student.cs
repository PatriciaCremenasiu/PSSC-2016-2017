using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Student
{
    /*
     * Entity which describes a 'student':
     * 1. Registration number
     * 2. Name
     * 3. Accumulated credits
     */
    public class Student : Entity<RegistrationNumber>
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
        public Credits Credits { get; internal set; }

        public Student(RegistrationNumber regNumber, PlainText name) : base(regNumber)
        {
            Contract.Requires(regNumber != null, "Registration number is null!");
            Contract.Requires(name != null, "Student name is null!");

            RegNumber = regNumber;
            Name = name;
        }

        public Student(RegistrationNumber regNumber, PlainText name, Credits credits)
            : this(regNumber, name)
        {
            Contract.Requires(credits != null, "Credits is null!");

            Credits = credits;
        }
    }
}
