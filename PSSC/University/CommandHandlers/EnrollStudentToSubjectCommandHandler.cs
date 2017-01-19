using Models.Contexts.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University.Commands;
using University.Storage;

namespace University.CommandHandlers
{
    public class EnrollStudentToSubjectCommandHandler : ICommandHandler<EnrollStudentToSubjectCommand>
    {
        private IRepository<EnrolledSubject> _repository;

        public EnrollStudentToSubjectCommandHandler(IRepository<EnrolledSubject> repository)
        {
            _repository = repository;
        }

        public void Execute(EnrollStudentToSubjectCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }
            //todo
           
        }
        }
}