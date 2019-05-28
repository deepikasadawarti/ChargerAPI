using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Models
{
    public class ChargerWithoutSessionsDto
    {
        public int id { get; set; }
        public string chargerStationType { get; set; }
        public int powerInVolt { get; set; }
    }
}
