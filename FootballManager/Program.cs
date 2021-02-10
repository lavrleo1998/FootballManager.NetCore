using Domain;
using Domain.Enum;
using Storage;
using System;
using System.Linq;

namespace FootballManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            Console.WriteLine();

            Console.ReadKey();
        }
}
}
