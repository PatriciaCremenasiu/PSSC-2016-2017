using System;
using System.Collections.Generic;
using University.Storage.Memento;

namespace Models.Contexts.Deanship
{
    public class StudyYearMemento : BaseMemento
    {
        public HashSet<DefinedSubject> _definedSubjects;

        public StudyYearMemento(Guid id, HashSet<DefinedSubject> _definedSubjects)
        {
            Id = id;
            this._definedSubjects = _definedSubjects;
        }

    }
}