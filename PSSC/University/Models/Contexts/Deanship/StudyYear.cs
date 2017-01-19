using Models.Common.Subject;
using Models.Generics;
using Models.Generics.ValueObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Events;
using University.Models;
using University.Storage.Memento;

namespace Models.Contexts.Deanship
{
    /*
     * Aggregate root
     * Deanship interacts with a list of 'DefinedSubjects'. It is able to:
     * 1. Define new subjects
     * 2. Enroll students to subjects
     * 3. View the subject situation for any student
     * 4. Calculate students average
     * 
     * !?TODO!?:
     * 1. Possibility to add students
     */
    public class StudyYear : AggregateRoot,
        IHandle<StudyYearCreatedEvent>,
        IHandle<StudyYearDeletedEvent>,
        IHandle<StudentAddedEvent>,
        IHandle<SubjectDefinedEvent>,
        IHandle<StudentEnrolledToSubjectEvent>,
        IHandle<SubjectSituationShowedEvent>,
        IHandle<StudentAverageCalculatedEvent>,
        IOriginator
    { 
        public HashSet<DefinedSubject> _definedSubjects;
        public List<DefinedSubject> Subjects {  get { return _definedSubjects.ToList(); } }

        public StudyYear()
        {

        }

        public StudyYear(Guid id, HashSet<DefinedSubject> definedSubjects)
        {
            ApplyChange(new StudyYearCreatedEvent(id, definedSubjects));


        }

        public void AddStudent(RegistrationNumber regNumber, PlainText name)
        {
            ApplyChange(new StudentAddedEvent(Id, regNumber, name));

        }
        public void DefineSubject(PlainText subjectName, Credits credits, Dictionary<Common.Student.Student, ViewableSituation> enrolledStudents,
            EvaluationType type, Common.Professor.Professor professor, Proportion prop)
        {
            ApplyChange(new SubjectDefinedEvent(Id, subjectName, credits, enrolledStudents, type, professor, prop));
        }

        public void EnrollStudentToSubject(PlainText subjectName, Common.Student.Student student)
        {
           
            ApplyChange(new StudentEnrolledToSubjectEvent(Id, subjectName, student));
         }

        public void CalculateStudentAverage(PlainText subjectName, RegistrationNumber regNumber)
        {
            ApplyChange(new StudentAverageCalculatedEvent(Id, subjectName, regNumber));
        }

        public void GetStudentSituation(PlainText subjectName, RegistrationNumber regNumber)
        {
            ApplyChange(new SubjectSituationShowedEvent(Id, subjectName, regNumber));
        }

        void IHandle<StudentAddedEvent>.Handle(StudentAddedEvent e)
        {
            throw new NotImplementedException();
        }
        

        void IHandle<StudentEnrolledToSubjectEvent>.Handle(StudentEnrolledToSubjectEvent e)
        {
            throw new NotImplementedException();
        }

        void IHandle<SubjectSituationShowedEvent>.Handle(SubjectSituationShowedEvent e)
        {
            throw new NotImplementedException();
        }

        void IHandle<StudentAverageCalculatedEvent>.Handle(StudentAverageCalculatedEvent e)
        {
            throw new NotImplementedException();
        }

        BaseMemento IOriginator.GetMemento()
        {
            return new StudyYearMemento(Id, _definedSubjects);
        }

        void IOriginator.SetMemento(BaseMemento memento)
        {
            _definedSubjects = ((StudyYearMemento)memento)._definedSubjects;
            Id = memento.Id;
            Version = memento.Version;
        }

        void IHandle<SubjectDefinedEvent>.Handle(SubjectDefinedEvent e)
        {
            throw new NotImplementedException();
        }

        void IHandle<StudyYearCreatedEvent>.Handle(StudyYearCreatedEvent e)
        {
            Id = e.AggregateId;
            Version = e.Version;
            _definedSubjects = e.definedSubjects;
        }

        public void Delete()
        {
            ApplyChange(new StudyYearDeletedEvent(Id));
        }


        void IHandle<StudyYearDeletedEvent>.Handle(StudyYearDeletedEvent e)
        {
        }
    }
}
