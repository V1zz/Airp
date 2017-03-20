using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VizAir.Models
{
    public class Passport
    {
        public int PassportId { get; set; }

        public string PassportSeries { get; set; }

        public string Nationality { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Birthday { get; set; }

        public Enums.Sex Sex { get; set; }

    }
}