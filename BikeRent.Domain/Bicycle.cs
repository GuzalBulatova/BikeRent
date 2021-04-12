using System;
using System.Collections.Generic;

namespace BikeRent.Domain
{
    public class Bicycle
    {
        public int BicycleId { get; set; }
        public float BicyclePrice { get; set; }
        public List<Rental> Rentals { get; set; } = new List<Rental>(); // *:*
    }
}
