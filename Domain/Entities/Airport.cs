using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string IATACode { get; set; }
    }
}
