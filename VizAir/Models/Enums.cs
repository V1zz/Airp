using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VizAir.Models
{
    public class Enums
    {
        public enum Type
        {
            Arrival = 1,
            Departure
        }

        public enum Status
        {
            delayed, 
            unknown,
            closed,
            departed,
            check_in,
            canceled,
            expected,
            in_flight,
            arrived
        }

        public enum Sex
        {
            Male,
            Famale
        }
    }
}