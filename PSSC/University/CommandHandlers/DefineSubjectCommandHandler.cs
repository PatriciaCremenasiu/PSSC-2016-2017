using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Commands;
using University.Storage;

namespace University.CommandHandlers
{
    public class DefineSubjectCommandHandler : ICommandHandler<DefineSubjectCommand>
    {
        private IRepository<DefinedSubject> _repository;

        public DefineSubjectCommandHandler(IRepository<DefinedSubject> repository)
        {
            _repository = repository;
        }

        public void Execute(DefineSubjectCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            var aggregate = new DefinedSubject(command.Id, command.professor, command.type, command.prop);
           //todo
        }
    }
}