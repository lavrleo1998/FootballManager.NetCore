using Domain;
using Repository.Interfaces;
using Repository.Repositores;
using Storage;

namespace Repository.Providers
{
    public class PersonProvider : Repository<Person>, IPersonProvider
    {
        public PersonProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
