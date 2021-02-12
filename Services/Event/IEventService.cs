using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IEventService
    {
        public Event GetEvent(long id);
        public List<Person> GetPersonsByEventId(long id);
    }
}
