using Models.Generics.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    /*
     * Used to describe a students grade - its value and the date of receival
     */
    public class Grade
    {
        private decimal _value;
        public decimal Value { get { return _value; } }

        private DateTime _date;
        public DateTime Date { get { return _date; } }

        public Grade(decimal value)
        {
            Contract.Requires<InvalidGradeValueException>(value > 0 && value <= 10, "Invalid value for grade!");

            _value = value;
        }

        public Grade(DateTime date, decimal value) : this(value)
        {
            _date = date;
        }
    }
}
