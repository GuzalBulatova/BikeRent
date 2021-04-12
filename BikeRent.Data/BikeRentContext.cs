using System;
using BikeRent.Domain;
using Microsoft.EntityFrameworkCore;

namespace BikeRent.Data
{
    public class BikeRentContext : DbContext
    {
        public BikeRentContext(DbContextOptions<BikeRentContext> options)
            : base(options)
        {
        }
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bicycle>()
                .HasMany(b => b.Rentals)
                .WithMany(r => r.Bicycles)
                .UsingEntity<BicycleRental>
                (br => br.HasOne<Rental>().WithMany(),
                br => br.HasOne<Bicycle>().WithMany())
                .Property(br => br.DateRented)
                .HasDefaultValueSql("getdate()");

            // Data Seeding
            modelBuilder.Entity<Bicycle>()
                .HasData(new Bicycle { BicycleId = 1, BicyclePrice = 300 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 2, BicyclePrice = 300 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 3, BicyclePrice = 300 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 4, BicyclePrice = 300 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 5, BicyclePrice = 300 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 6, BicyclePrice = 400 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 7, BicyclePrice = 400 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 8, BicyclePrice = 400 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 9, BicyclePrice = 500 });
            modelBuilder.Entity<Bicycle>()
               .HasData(new Bicycle { BicycleId = 10, BicyclePrice = 500 });
            modelBuilder.Entity<Customer>()
               .HasData(new Customer
               {
                   CustomerId = 1,
                   FirstName = "Anna",
                   LastName = "Tornberg",
                   Email = "a.tornberg@fake.com",
                   PhoneNumber = "0765009080"
               });
            modelBuilder.Entity<Customer>()
               .HasData(new Customer
               {
                   CustomerId = 2,
                   FirstName = "Clint",
                   LastName = "Eastwood",
                   Email = "theclint@fake.com",
                   PhoneNumber = "0765432101"
               });
            modelBuilder.Entity<Customer>()
               .HasData(new Customer
               {
                   CustomerId = 3,
                   FirstName = "Peter",
                   LastName = "Ström",
                   Email = "p.strom@fake.com",
                   PhoneNumber = "0765559900"
               });
            modelBuilder.Entity<Customer>()
               .HasData(new Customer
               {
                   CustomerId = 4,
                   FirstName = "Pippi",
                   LastName = "Blomqvist",
                   Email = "p.blomqvist@fake.com",
                   PhoneNumber = "0767776655"
               });
            modelBuilder.Entity<Customer>()
               .HasData(new Customer
               {
                   CustomerId = 5,
                   FirstName = "Rebecca",
                   LastName = "Dunger",
                   Email = "r.dunger@fake.com",
                   PhoneNumber = "0764445511"
               });
            modelBuilder.Entity<Rental>()
                .HasData(new Rental
                {
                    CustomerId = 1,
                    RentalId = 1,
                    RentalStartDate = new DateTime(2021, 05, 01),
                    RentalEndDate = new DateTime(2021, 05, 15)
                });
            modelBuilder.Entity<Rental>()
                .HasData(new Rental
                {
                    CustomerId = 2,
                    RentalId = 2,
                    RentalStartDate = new DateTime(2021, 05, 10),
                    RentalEndDate = new DateTime(2021, 05, 11)
                });
            modelBuilder.Entity<BicycleRental>()
                .HasData(new BicycleRental
                {
                    BicycleId = 1,
                    RentalId = 1
                });
            modelBuilder.Entity<BicycleRental>()
                .HasData(new BicycleRental
                {
                    BicycleId = 10,
                    RentalId = 2
                });
             modelBuilder.Entity<BicycleRental>()
                .HasData(new BicycleRental
                {
                    BicycleId = 9,
                    RentalId = 2
                });
        }
    }
}
