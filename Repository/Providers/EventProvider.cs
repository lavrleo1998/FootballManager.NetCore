using Domain;
using Repository.Interfaces;
using Repository.Repositores;
using Storage;

namespace Repository.Providers
{
    public class EventProvider : Repository<Event>, IEventProvider
    {
        public EventProvider(AppDbContext context)
            : base(context)
        {
        }
    }
}
