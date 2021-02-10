using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain.Event
{
    public class Event : PersistentObject
    {
        public DateTime DateTime { get; set; }
        public EventType EventType { get; set; }
        public Event()
        {
            People = new HashSet<EventPerson>();
        }
        public virtual ICollection<EventPerson> People { get; set; }
    }
}
