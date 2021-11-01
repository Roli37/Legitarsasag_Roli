using Legitarsasag_Roli.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
