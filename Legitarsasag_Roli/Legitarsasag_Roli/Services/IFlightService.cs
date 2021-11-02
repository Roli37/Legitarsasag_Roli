using Legitarsasag_Roli.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Services
{
    public interface IFlightService
    {
        Flight FindById(int id);
        List<Flight> FindAll();
        Flight Save(Flight inputData);
        Flight Update(int id, Flight updateData);
        void Delete(int id);
    }
}
