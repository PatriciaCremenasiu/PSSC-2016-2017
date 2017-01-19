using Models.Generics;
using Models.Generics.ValueObjects;
using System.Diagnostics.Contracts;

namespace Models.Common.Subject
{
    /*
     * Basic subject scheleton - Name and credits
     */
    public abstract class Subject : Entity<PlainText>
    {
        private Subject subjectName;
        private PlainText subjectName1;

        public PlainText Name { get;  set; }
        public Credits Credits { get;  set; }

        public Subject(PlainText name, Credits credits) : base(name)
        {
            Contract.Requires(name != null, "Name is null!");
            Contract.Requires(credits != null, "Credits is null!");

            Name = name;
            Credits = credits;
        }

       
    }
}
