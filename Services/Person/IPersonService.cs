using Domain;

namespace Services
{
    public interface IPersonService
    {
        Person GetPerson(long id);
    }
}
