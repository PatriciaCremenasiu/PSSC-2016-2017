using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.CommandHandlers;
using University.Commands;

namespace University.Utilis
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
