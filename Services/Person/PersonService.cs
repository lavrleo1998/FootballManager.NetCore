using Domain;
using Domain.Enum;
using Repository.Interfaces;
using Storage;
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

        public void Test()
        {

            var context = new AppDbContext();

            #region Init
            context.Add(new Person()
            {
                Name = "Name",
                PersonType = PersonType.Footboller,
                Composition = Composition.Main,
                Position = Position.Coach
            });


            context.SaveChanges();

            #endregion

            var person = context.Persons.FirstOrDefault();
            person.Name = "Another Name";

            context.Persons.Update(person);
            context.SaveChanges();
        }
    }
}
