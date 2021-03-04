using Domain;
using Domain.Enum;
using DTO;
using DTO.Request;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonProvider PersonProvider;
        public PersonService(IPersonProvider personProvider)
        {
            PersonProvider = personProvider;
        }

/// <summary>
/// ВОт как работает DTO!
/// </summary>
/// <param name="request"></param>

        public void CreatePerson(CreatePersonDTO request)
        {
             var newPerson = new Person
                {
                    Name = request.Name,
                    PersonType = request.PersonType,
                };
            PersonProvider.Create(newPerson);
            PersonProvider.SaveChanges();
        }

        public void Add(string name, PersonType personType, Composition composition, Position position)
        {
            var person = new Person(name, personType, composition, position);
            PersonProvider.Create(person);
            PersonProvider.SaveChanges();
        }



















        public void Update(string name, PersonType personType, Composition composition, Position position)
        {
            var person = new Person(name, personType, composition, position);
            PersonProvider.Update(person);
            PersonProvider.SaveChanges();
        }


        public Person Get(long id)
        {
            var person = PersonProvider
                .GetAll()
                .FirstOrDefault(x => x.Id == id);
            return person;
        }

        public List<Event> GetEventsByPersonId(long id)
        {
            var events = PersonProvider
                .GetAll()
                .Include(x => x.Events)
                .ThenInclude(x => x.Event)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return events.Events.Select(x => x.Event).ToList();
        }

        public void Remove(long id)
        {
            var scope = Installer.Init();
            var personService = scope.GetRequiredService<IPersonService>();
            var person = personService.Get(id) ?? throw new ServiceErrorException(863);
            PersonProvider.Remove(person);
            PersonProvider.SaveChanges();
        }

        public void Test()
        {

            var context = new AppDbContext();

            #region Init
            context.Add(new Person()
            {
                Name = "Name",
                PersonType = PersonType.Footboller,
                Composition = Composition.Main,
                Position = Position.Coach
            });


            context.SaveChanges();

            #endregion

            var person = context.Persons.FirstOrDefault();
            person.Name = "Another Name";

            context.Persons.Update(person);
            context.SaveChanges();
        }

    }
}
