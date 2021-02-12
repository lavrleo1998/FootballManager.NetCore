using Domain.Entity;
using Domain.Enum;

namespace Domain
{
    public class Person : PersistentObject
    {
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
        public Composition Composition { get; set; }
        public Position Position { get; set; }

        public override string ToString()
        {
            return $"{Name} {PersonType} {Composition} {Position}";
        }
    }
}
