using Domain;
using Domain.Enum;

namespace DTO.Response
{
    public class PersonDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public PersonType PersonType { get; set; }
        public Composition Composition { get; set; }
        public Position Position { get; set; }

        public PersonDTO() { }

        public PersonDTO(Person person)
        {
            if (person == null)
            {
                return;
            }
            Id = person.Id;
            Name = person.Name;
            PersonType = person.PersonType;
            Composition = person.Composition;
            Position = person.Position;
        }

    }
}
