using Domain;
using Domain.Event;
using Microsoft.EntityFrameworkCore;

namespace Storage
{
    public class AppDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<EventPerson> EventPeopleS { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAVRLEO-HP\\SQLEXPRESS;Database=FootballBD;Trusted_Connection=True;");
        }
    }
}
