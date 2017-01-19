using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Commands;

namespace University.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
