using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Common.Professor
{
    /*
     * Entity which describes a 'professor'
     */
    public class Professor : Entity<PlainText>
    {
        public PlainText Name { get; internal set; }

        public Professor(PlainText name) : base(name)
        {
            Contract.Requires(name != null, "Professor name is null!");

            Name = name;
        }
    }
}
