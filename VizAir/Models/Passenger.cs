using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VizAir.Models
{
    public class Passenger
    {
        [Key]
        public int PassengerId { get; set; }

        public int FlightId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Passport Passport { get; set; }
    }
}