using Domain;
using Domain.Enum;
using DTO.Request;
using System.Collections.Generic;

namespace Services
{
    public interface IPersonService
    {
        public void CreatePerson(CreatePersonDTO request);

        public void Add(string name, PersonType personType, Composition composition, Position position);
        public void Update(string name, PersonType personType, Composition composition, Position position);
        Person Get(long id);
        public List<Event> GetEventsByPersonId(long id);
        public void Remove(long id);
    }
}
