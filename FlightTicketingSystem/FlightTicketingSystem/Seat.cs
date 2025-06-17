using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketingSystem
{
    public class Seat
    {
        public int SeatID { get; set; }
        public int AircraftID { get; set; }
        public string SeatNumber { get; set; }
        public bool IsBooked { get; set; }
    }
}
