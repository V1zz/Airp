using System.Collections.Generic;

namespace VizAir.Models
{
    public class BuisnesClass
    {
        public int NumberOfSeats { get; set; }

        public List<Passenger> Passengers { get; set; }

        public Flight Flight { get; set; }

        public double Price { get; set; }
    }

    
}