using System;
using System.Collections.Generic;

namespace BikeRent.Domain
{
    public class Rental
    {
        public int RentalId { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public List<Bicycle> Bicycles { get; set; } = new List<Bicycle>(); //*:*
        public int CustomerId { get; set; } // FK, must have a Customer
    }
}
