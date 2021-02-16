using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
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

        public Event Get(long id)
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
        }


        public void Remove(long id)
        {
            var scope = Installer.Init();
            var eventService = scope.GetRequiredService<IEventService>();
            var Event = eventService.Get(id) ?? throw new ServiceErrorException(863);
            EventProvider.Remove(Event);
            EventProvider.SaveChanges();
        }

    }
}
