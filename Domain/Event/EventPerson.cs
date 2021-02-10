using Domain.Entity;

namespace Domain.Event
{
    public class EventPerson : PersistentObject
    {
        public long EventId { get; set; }
        public Event Event { get; set; }

        public long PersonID { get; set; }
        public Person Person { get; set; }
    }
}
