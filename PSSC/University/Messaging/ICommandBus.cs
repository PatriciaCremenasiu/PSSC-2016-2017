using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Commands;

namespace University.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
