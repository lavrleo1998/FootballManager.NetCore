using Domain;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class EventService : IEventService
    {
        private readonly IEventProvider EventProvider;
        public EventService(IEventProvider eventProvider)
        {
            EventProvider = eventProvider;
        }

        public Event GetEvent(long id)
        {
            var person = EventProvider
                .GetAll()
                .FirstOrDefault(x => x.Id == id);
            return person;
        }

        public List<Person> GetPersonsByEventId(long id)
        {
            var persons = EventProvider
                .GetAll()
                .Include(x => x.People)
                .ThenInclude(x => x.Person)
                .Where(x => x.Id == id)
                .FirstOrDefault();

            return persons.People.Select(x => x.Person).ToList();



            ///List<Person> people
        }

    }
}
