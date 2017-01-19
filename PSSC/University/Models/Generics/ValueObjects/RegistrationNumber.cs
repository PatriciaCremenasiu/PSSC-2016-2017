using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    /*
     * Used as an unique identifier for students
     */
    public class RegistrationNumber
    {
        private string _number;
        public string Number { get { return _number; } }

        public RegistrationNumber(string number)
        {
            Contract.Requires(number.Length > 3 && number.Length <= 10, "Invalid registration number length!");

            _number = number;
        }
    }
}
