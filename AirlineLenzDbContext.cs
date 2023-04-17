using AirlineLenz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineLenz
{
    public class AirlineLenzDbContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Liner> Liners { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Crew> Crews { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseInMemoryDatabase("db");
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=AirlineLenz2;Username=postgres;Password=6969");
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Route>()
                .HasMany(x => x.WayPoints)
                .WithMany(x => x.Routes)
                .UsingEntity(j => j.ToTable("WayPoints"));

            modelBuilder.Entity<Route>()
                .HasOne(x => x.StartingPoint)
                .WithMany();

            modelBuilder.Entity<Route>()
               .HasOne(x => x.EndingPoint)
               .WithMany();

            modelBuilder.Entity<Crew>()
                .HasMany(x => x.Employees)
                .WithMany(x => x.Crews)
                .UsingEntity(j => j.ToTable("FlightCrew"));

            modelBuilder.Entity<Ticket>()
                .HasOne(x => x.Departure)
                .WithMany();
             

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveConversion<UtcValueConverter>();
            configurationBuilder.Properties<DateTime?>().HaveConversion<UtcValueConverter>();
            base.ConfigureConventions(configurationBuilder);
        }

        private class UtcValueConverter : ValueConverter<DateTime, DateTime>
        {
            public UtcValueConverter()
                : base(v => v, v => DateTime.SpecifyKind(v, DateTimeKind.Utc))
            {
            }
        }
    }
}
