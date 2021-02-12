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
                .AddScoped<IEventProvider, EventProvider>()
                .AddScoped<IEventPersonService, EventPersonService>()
                .AddScoped<IEventPersonProvider, EventPersonProvider>();
            return serviceConllection.BuildServiceProvider();
        }
        public static void AddBuisnessServices(this IServiceCollection container)
        {
            container
                .AddDbContext<AppDbContext>()
                .AddScoped<IPersonService, PersonService>()
                .AddScoped<IPersonProvider, PersonProvider>()
                .AddScoped<IEventService, EventService>()
                .AddScoped<IEventProvider, EventProvider>()
                .AddScoped<IEventPersonService, EventPersonService>()
                .AddScoped<IEventPersonProvider, EventPersonProvider>();
            ///в асп нет не нужно возвращать контейнер(((
        }
    }
}
