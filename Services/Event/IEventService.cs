using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IEventService
    {
        public Event Get(long id);
        public List<Person> GetPersonsByEventId(long id);
        public void Remove(long id);
    }
}
