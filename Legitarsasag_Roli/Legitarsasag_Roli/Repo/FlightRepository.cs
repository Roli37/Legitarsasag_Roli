using Legitarsasag_Roli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Repo
{
    public class FlightRepository
    {
        private List<Flight> flights = new List<Flight>();
        private int nextIncrementalId = 0;
        public List<Flight> Flights { get => flights; }
        public int NextIncrementalId { get => ++nextIncrementalId; }
    }
}
