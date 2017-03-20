using System.Collections.Generic;

namespace VizAir.Models
{
    public class EconomClass
    {
        public int NumberOfSeats { get; set; }

        public List<Passenger> Passengers { get; set; }

        public Flight Flight { get; set; }

        private double Price { get; set; }

        public string GetPrice()
        {
            return $"{Price:##.###}";
        }

        public double SetPrice
        {
            set { Price = value; }
        }
    }
}