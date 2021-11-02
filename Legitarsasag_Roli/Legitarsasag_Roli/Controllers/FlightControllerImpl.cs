using Legitarsasag_Roli.Entities;
using Legitarsasag_Roli.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Controllers
{
    public class FlightControllerImpl : FlightControllerBase
    {
        private readonly IFlightService flightService;
        public FlightControllerImpl(IFlightService flightService)
        {
            this.flightService = flightService;
        }
        public override void Delete(int id)
        {
            flightService.Delete(id);
        }
        public override List<Flight> FindAll()
        {
            return flightService.FindAll();
        }
        public override Flight FindById(int id)
        {
            return flightService.FindById(id);
        }
        public override Flight Save(Flight inputData)
        {
            return flightService.Save(inputData);
        }

        public override Flight Update(int id, Flight updateData)
        {
            return flightService.Update(id, updateData);
        }
    }
}
