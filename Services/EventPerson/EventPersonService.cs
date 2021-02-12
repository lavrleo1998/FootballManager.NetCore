using Domain;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Storage;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class EventPersonService : IEventPersonService
    {
        private readonly IEventPersonProvider EventPersonProvider;
        public EventPersonService(IEventPersonProvider eventpersonProvider)
        {
            EventPersonProvider = eventpersonProvider;
        }

        public EventPerson GetEventPerson(long id)
        {
            var eventPerson = EventPersonProvider
                .GetAll()
                .FirstOrDefault(x => x.Id == id);
            return eventPerson;
        }
     
    }
}