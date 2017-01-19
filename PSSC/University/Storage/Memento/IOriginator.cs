using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Storage.Memento
{
    public interface IOriginator
    {
        BaseMemento GetMemento();
        void SetMemento(BaseMemento memento);
    }
}
