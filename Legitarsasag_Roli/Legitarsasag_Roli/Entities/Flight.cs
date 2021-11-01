using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Entities
{
    public class Flight
    {
        public string Name { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        public int Distance { get; set; }
        public int Duration { get; set; }
    }
}
