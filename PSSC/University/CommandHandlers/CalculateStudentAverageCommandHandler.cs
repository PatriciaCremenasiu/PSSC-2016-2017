using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Commands;
using University.Storage;

namespace University.CommandHandlers
{
    public class CalculateStudentAverageCommandHandler : ICommandHandler<CalculateStudentAverageCommand>
    {
        private IRepository<StudyYear> _repository;

        public CalculateStudentAverageCommandHandler(IRepository<StudyYear> repository)
        {
            _repository = repository;
        }

        public void Execute(CalculateStudentAverageCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
        }
        }
}