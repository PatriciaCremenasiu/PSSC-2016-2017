using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Commands;
using University.Storage;

namespace University.CommandHandlers
{
    public class CreateStudyYearCommandHandler : ICommandHandler<CreateStudyYearCommand>
    {
        private IRepository<StudyYear> _repository;

        public CreateStudyYearCommandHandler(IRepository<StudyYear> repository)
        {
            _repository = repository;
        }

        public void Execute(CreateStudyYearCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            var aggregate = new StudyYear(command.Id, command._definedSubjects);
            aggregate.Version = -1;
            _repository.Save(aggregate, aggregate.Version);
        }
    }
}