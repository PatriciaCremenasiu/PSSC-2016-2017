using System;

namespace University.Models.Context.Deanship
{
    public class BaseMemento
    {
        public Guid Id { get; internal set; }
        public int Version { get; set; }
    }
}
