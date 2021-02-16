using Domain.Entity;

namespace Domain
{
    public class EventPerson : PersistentObject
    {
        public long EventId { get; set; }
        public Event Event { get; set; }

        public long PersonID { get; set; }
        public Person Person { get; set; }

        public override string ToString()
        {
            return $"{EventId} {Event} {PersonID} {Person}";
        }
    }
}
