using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketingSystem
{
    public class ViewBooking
    {
        public int BookingID { get; set; }
        public int SeatID { get; set; }
        public string Passenger { get; set; }
        public string Contact { get; set; }
        public string FlightNumber { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string SeatNumber { get; set; }
        public DateTime DepartureTime { get; set; }

    }
}
