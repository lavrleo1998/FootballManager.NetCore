using Domain;
using Repository.Interfaces;
using Repository.Repositores;
using Storage;

namespace Repository.Providers
{
    public class EventPersonProvider : Repository<EventPerson>,IEventPersonProvider
    {
        public EventPersonProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
