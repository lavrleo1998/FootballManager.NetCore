using Microsoft.Extensions.DependencyInjection;
using Services;
using System;

namespace FootballManager
{
    class Program
    {
        static void Main()
        {
            var scope = Installer.Init();
            var personService = scope.GetRequiredService<IPersonService>();
            var eventService = scope.GetRequiredService<IEventService>();



            Console.WriteLine(personService.GetPerson(1).Name + " " + personService.GetPerson(1).Position + " " + personService.GetPerson(1).PersonType);
            Console.WriteLine(personService.GetPerson(2).Name + " " + personService.GetPerson(2).Position + " " + personService.GetPerson(2).PersonType);

            Console.WriteLine(eventService.Get(2).DateTime.Date.ToString() + " " + eventService.Get(2).EventType.ToString());
            eventService.GetPersonsByEventId(2).ForEach(x => Console.WriteLine(x));
            Console.WriteLine(eventService.Get(5).DateTime.Date.ToString() + " " + eventService.Get(5).EventType.ToString());
            eventService.GetPersonsByEventId(5).ForEach(x => Console.WriteLine(x));
            Console.WriteLine(eventService.Get(6).DateTime.Date.ToString() + " " + eventService.Get(6).EventType.ToString());
            eventService.GetPersonsByEventId(6).ForEach(x => Console.WriteLine(x));


            Console.ReadKey();
        }


    }
}
