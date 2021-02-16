using Domain.Entity;
using Domain.Enum;
using System.Collections.Generic;

namespace Domain
{
    public class Person : PersistentObject
    {
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
        public Composition Composition { get; set; }
        public Position Position { get; set; }
        public Person()
        {
            Events = new HashSet<EventPerson>();
        }
        public virtual ICollection<EventPerson> Events { get; set; }
        public override string ToString()
        {
            return $"{Name} {PersonType} {Composition} {Position}";
        }

        public Person (string name, PersonType personType, Composition composition, Position position)
          {
            //Id = person.Id;
            Name = name;
            PersonType = personType;
            Composition = composition;
            Position = position;
        }
}
}
