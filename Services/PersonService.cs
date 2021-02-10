using Domain;
using Repository.Interfaces;
using System.Linq;

namespace Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonProvider PersonProvider;

        public PersonService(IPersonProvider personProvider)
        {
            PersonProvider = personProvider;
        }

        public Person GetPerson(long id)
        {
            var person = PersonProvider
                .GetAll()
                .FirstOrDefault(x => x.Id == id);

            return person;

        }
    }
}
