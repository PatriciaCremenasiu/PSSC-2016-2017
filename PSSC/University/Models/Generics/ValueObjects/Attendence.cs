using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics.ValueObjects
{
    /*
     * Used to mark a point in time, when the student was present at a certain Subject
     */
    public class Attendance
    {
        private DateTime _date;
        public DateTime Date { get { return _date; } }

        public Attendance(DateTime date)
        {
            _date = date;
        }
    }
}
