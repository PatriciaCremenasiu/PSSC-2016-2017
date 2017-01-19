using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Commands;
using University.Storage;

namespace University.CommandHandlers
{
    public class DeleteStudyYearCommandHandler : ICommandHandler<DeleteStudyYearCommand>
    {
        private readonly IRepository<StudyYear> _repository;

        public DeleteStudyYearCommandHandler(IRepository<StudyYear> repository)
        {
            _repository = repository;
        }

        public void Execute(DeleteStudyYearCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.GetById(command.Id);
            aggregate.Delete();
            _repository.Save(aggregate, aggregate.Version);

        }
    }
}