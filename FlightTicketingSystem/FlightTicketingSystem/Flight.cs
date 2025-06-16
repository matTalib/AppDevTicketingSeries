using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketingSystem
{
    public class Flight
    {
        public int FlightID { get; set; }
        public int AircraftID { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public DateTime DepartureTime { get; set; }
        public string FlightNumber { get; set; }

    }
}
