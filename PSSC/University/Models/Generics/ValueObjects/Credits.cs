using Models.Generics.Exceptions;
using System.Diagnostics.Contracts;

namespace Models.Generics.ValueObjects
{
    /*
     * Used to mark the total amount of credits which a subject yields OR the total amount of credits which a student has
     * //TODO: Might need refactoring here
     */
    public class Credits
    {
        private int _credits;
        public int Count { get { return _credits; } }

        public Credits(int credits)
        {
            Contract.Requires<InvalidCreditsValueException>(credits >= 0 && credits <= 60, "Invalid value for credits!");
            
            _credits = credits;
        }
    }
}
