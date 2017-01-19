using Models.Contexts.Deanship;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace University.EventHandlers
{
    public class StudyYearDto
    {
        public Guid Id { get; set; }
        public int Version { get; set; }

        [Required]
        public HashSet<DefinedSubject> _definedSubjects;

        [Required]
        public List<DefinedSubject> Subjects { get { return _definedSubjects.ToList(); } }

    }
}