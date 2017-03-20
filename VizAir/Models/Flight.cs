using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VizAir.Models
{
    public class Flight
    {
        public int FlightId { get; set; }

        public string Airline { get; set; }

        public string Port { get; set; }

        public string Status { get; set; }

        public DateTime Time { get; set; }

        public Type Type { get; set; }

        public string Terminal { get; set; }

        public int Gate { get; set; }

        public Enums.Status FlightStatus { get; set; } //todo with duplicate

        public BuisnesClass BuisnesClass { get; set; }


        public TYPE Type1 { get; set; }
    }
}