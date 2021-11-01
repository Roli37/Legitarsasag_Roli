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
            foreach (string sor in File.ReadAllLines("input_flight.txt"))
            {
                int n = 0;
                n += 1;
                string[] s = sor.Split(';');
                modelBuilder.Entity<Flight>().HasData(new Flight
                {
                    Id = n,
                    Airline = s[0],
                    CityFrom = s[1],
                    CityTo = s[2],
                    Distance = int.Parse(s[3]),
                    Duration = int.Parse(s[4])
                });
                modelBuilder.Entity<Airline>().HasData(new Airline
                {
                    Id = n,
                    Name = s[0]
                });
            }
            foreach (string sor in File.ReadAllLines("input_city.txt"))
            {
                int n = 0;
                n += 1;
                string[] s = sor.Split(';');
                modelBuilder.Entity<City>().HasData(new City
                {
                    Id = n,
                    Name = s[0],
                    Population = int.Parse(s[1])
                });
                base.OnModelCreating(modelBuilder);
            }
        }
    }
}
