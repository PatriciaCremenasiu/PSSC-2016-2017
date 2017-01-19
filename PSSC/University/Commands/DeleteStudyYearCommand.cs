using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University.Commands
{
    public class DeleteStudyYearCommand : Command
    {
        public DeleteStudyYearCommand(Guid id, int version) : base(id, version)
        {
        }
    }
}