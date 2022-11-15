using Aeroport.Classes;
using Microsoft.EntityFrameworkCore;

namespace Aeroport
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Flight> ADB { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
         : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().HasKey(x => x.Id);
        }
    }
}
