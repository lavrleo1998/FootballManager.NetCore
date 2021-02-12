using Domain;

namespace Services
{
    public interface IEventPersonService
    {
        EventPerson GetEventPerson(long id);
    }
}
