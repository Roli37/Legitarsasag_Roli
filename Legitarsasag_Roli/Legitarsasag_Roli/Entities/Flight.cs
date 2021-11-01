using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Legitarsasag_Roli.Entities
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Airline { get; set; }
        [Required]
        public string CityFrom { get; set; }
        [Required]
        public string CityTo { get; set; }
        [Required]
        [MaxLength(10)]
        public int Distance { get; set; }
        [Required]
        [MaxLength(10)]
        public int Duration { get; set; }
    }
}
