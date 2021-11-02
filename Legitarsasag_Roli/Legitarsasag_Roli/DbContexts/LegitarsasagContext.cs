using Legitarsasag_Roli.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Legitarsasag_Roli.DbContexts
{
    public class LegitarsasagContext : DbContext
    {
        public LegitarsasagContext(DbContextOptions<LegitarsasagContext> options) : base(options)
        {
        }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Flight> Flights { get; set; }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            int a = 1;
            int b = 1;
            foreach (string sor in File.ReadAllLines("input_flight.txt"))
            {
                string[] s = sor.Split(';');
                modelBuilder.Entity<Flight>().HasData(new Flight
                {
                    Id = a,
                    Airline = s[0],
                    CityFrom = s[1],
                    CityTo = s[2],
                    Distance = int.Parse(s[3]),
                    Duration = int.Parse(s[4])
                });
                modelBuilder.Entity<Airline>().HasData(new Airline
                {
                    Id = a,
                    Name = s[0]
                });
                a++;
            }
            foreach (string sor in File.ReadAllLines("input_city.txt"))
            {
                string[] s = sor.Split(';');
                modelBuilder.Entity<City>().HasData(new City
                {
                    Id = b,
                    Name = s[0],
                    Population = int.Parse(s[1])
                });
                b++;
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
