using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Generics
{
    /*
     * Why implement IEquatable? - http://stackoverflow.com/questions/2476793/when-to-use-iequatable-and-why
     * 1. Performance boost for generic collection objects functions (Contains, IndexOf, etc...)
     * 2. No boxing
     * 
     * What should a base entity class contain?
     * 1. The Id of course (Table key)
     * 2. Common logic
     * 
     * https://vaughnvernon.co/?p=879
     * http://enterprisecraftsmanship.com/2014/11/08/domain-object-base-class/
     * http://stackoverflow.com/questions/6218328/base-classes-entity-and-valueobject-in-domain-driven-design
     * http://stackoverflow.com/questions/2326288/implementing-ddd-entity-class-in-c-sharp
     * 
     * Entity class used to offer 'identity' to domain entities
     */

    public abstract class Entity<T> : IEquatable<T>
    {
        public T Id { get; protected set; }

        public Entity(T id)
        {
            Id = id;
        }

        public override bool Equals(object obj)
        {
            return this.Equals((T) obj);
        }

        public bool Equals(T other)
        {
            return Id.Equals(other);
        }

        public override int GetHashCode()
        {
            return (GetType().ToString() + Id).GetHashCode();
        }
    }
}
