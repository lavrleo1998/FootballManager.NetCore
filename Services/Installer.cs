using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using Repository.Providers;
using Storage;

namespace Services
{
    public static class Installer
    {
        public static ServiceProvider Init()
        {
            var serviceConllection = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddScoped<IPersonService, PersonService>()
                .AddScoped<IPersonProvider, PersonProvider>()
                .AddScoped<IEventService, EventService>()
                .AddScoped<IEventProvider, EventProvider>();
            return serviceConllection.BuildServiceProvider();
        }


        //вариант для asp.net
        public static void AddBuisnessServices(this IServiceCollection container)
        {
            container
                .AddDbContext<AppDbContext>()
                .AddScoped<IPersonService, PersonService>()
                .AddScoped<IPersonProvider, PersonProvider>()
                .AddScoped<IEventService, EventService>()
                .AddScoped<IEventProvider, EventProvider>();
            ///в asp.net не нужно возвращать контейнер(((
        }
    }
}
