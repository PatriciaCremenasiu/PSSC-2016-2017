using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Contexts.Deanship
{
    //Strategy Signature
    public interface IReportStrategy
    {
        PlainText GenerateReport(List<Common.Student.Student> students);
    }

    //Strategy Context
    public interface IReportPublisher
    {
        void Publish(IReportStrategy strategy);
    }

}
