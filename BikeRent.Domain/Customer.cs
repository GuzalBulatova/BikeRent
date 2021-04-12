using System.Collections.Generic;

namespace BikeRent.Domain
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public int RentalId { get; set; } // reference property
        public List<Rental> Rentals { get; set; } = new List<Rental>();
        // 1:*, one Customer has many Rentals
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
