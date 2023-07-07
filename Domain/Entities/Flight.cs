using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string DepartureAirport { get; set; }
        public string ArrivalAirport { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
    }
}
