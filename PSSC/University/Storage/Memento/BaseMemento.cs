using System;

namespace University.Storage.Memento
{
    public class BaseMemento
    {
        public Guid Id { get; internal set; }
        public int Version { get; internal set; }
    }
}