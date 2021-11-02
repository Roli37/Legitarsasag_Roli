using Legitarsasag_Roli.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Controllers
{
    [Route("flight")]
    public abstract class FlightControllerBase : ControllerBase
    {
        [HttpGet]
        public abstract List<Flight> FindAll();
        [HttpGet("{id}")]
        public abstract Flight FindById(int id);
        [HttpPost]
        public abstract Flight Save([FromBody] Flight inputData);
        [HttpPut("{id}")]
        public abstract Flight Update(int id, [FromBody] Flight updateData);
        [HttpDelete("{id}")]
        public abstract void Delete(int id);
    }
}
