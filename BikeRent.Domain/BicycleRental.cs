using System;

namespace BikeRent.Domain
{
    public class BicycleRental
    {
        public int BicycleId { get; set; }
        public int RentalId { get; set; }
        public DateTime DateRented { get; set; }
    }
}
