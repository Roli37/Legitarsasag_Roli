using Legitarsasag_Roli.Entities;
using Legitarsasag_Roli.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Services
{
    public class FlightServiceImpl : IFlightService
    {
        private readonly FlightRepository flightRepository;
        public FlightServiceImpl(FlightRepository flightRepository)
        {
            this.flightRepository = flightRepository;
        }
        public void Delete(int id)
        {
            flightRepository.Flights.Remove(FindById(id));
        }

        public List<Flight> FindAll()
        {
            return flightRepository.Flights;
        }

        public Flight FindById(int id)
        {
            return flightRepository.Flights.Find(x => x.Id == id);
        }

        public Flight Save(Flight inputData)
        {
            inputData.Id = flightRepository.NextIncrementalId;
            flightRepository.Flights.Add(inputData);
            return inputData;
        }

        public Flight Update(int id, Flight updateData)
        {
            var dbFlight = FindById(id);
            if (dbFlight != null)
            {
                dbFlight.Id = updateData.Id;
                dbFlight.Airline = updateData.Airline;
                dbFlight.CityFrom = updateData.CityFrom;
                dbFlight.CityTo = updateData.CityTo;
                dbFlight.Distance = updateData.Distance;
                dbFlight.Duration = updateData.Duration;
            }
            return dbFlight;
        }
    }
}
