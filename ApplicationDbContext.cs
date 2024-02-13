﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using WatchCar.Models;

namespace WatchCar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Car> NewToy { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; } // DbSet for Manufacturer entity

        /*modelBuilder.Entity<Car>(): This method configures the entity type Car in the model.
         SQL query generated by EF Core for that entity type will include the filter condition.
        Query filters are useful for implementing soft-delete functionality (where entities are 
        marked as deleted but not physically removed from the database) or for implementing other 
        global query constraints based on entity properties. 
        They help maintain consistent behavior across your application's data access layer 
        without needing to explicitly specify the filter condition in every query.
         */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manufacturer>().HasData(
       new Manufacturer
       {
           ManufacturerId = 1,
           Name = "Toyota"
       },
       new Manufacturer
       {
           ManufacturerId = 2,
           Name = "Honda"
       },
       new Manufacturer
       {
           ManufacturerId = 3,
           Name = "Volkswagen"
       },
       new Manufacturer
       {
           ManufacturerId = 4,
           Name = "BMW"
       },
       new Manufacturer
       {
           ManufacturerId = 5,
           Name = "Hyundi"
       }
   );
            modelBuilder.Entity<Car>()
            .HasOne(c => c.Manufacturer) // Define the relationship
            .WithMany(m => m.Cars) // One-to-many relationship: one Manufacturer has many Cars
            .HasForeignKey(c => c.ManufacturerId); // Define the foreign key property

            modelBuilder.Entity<Car>().HasQueryFilter(x => !x.IsDeleted); // Configure soft delete filter
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    CarId = 1,
                    Name = "Corola",
                    Rate = 20000,
                    lenght = 10,
                    Color = "White",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    ManufacturerId = 1
                },
                 new Car
                 {
                     CarId = 2,
                     Name = "Civic",
                     Rate = 23000,
                     lenght = 11,
                     Color = "White",
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                     ManufacturerId = 2
                 },
                  new Car
                  {
                      CarId = 3,
                      Name = "Golf GT",
                      Rate = 10000,
                      lenght = 9,
                      Color = "Black",
                      CreatedDate = DateTime.Now,
                      UpdatedDate = DateTime.Now,
                      ManufacturerId = 3
                  },
                   new Car
                   {
                       CarId = 4,
                       Name = "BMW Series 3",
                       Rate = 30000,
                       lenght = 8,
                       Color = "Gold",
                       CreatedDate = DateTime.Now,
                       UpdatedDate = DateTime.Now,
                       ManufacturerId = 4

                   },
                    new Car
                    {
                        CarId = 5,
                        Name = "Accent",
                        Rate = 40000,
                        lenght = 12,
                        Color = "Blue",
                        CreatedDate = DateTime.Now,
                        UpdatedDate = DateTime.Now,
                        ManufacturerId = 5
                    }
                    );


        }
        public override int SaveChanges()
        {
            // Implementing Soft Delete Logic here
            foreach (var entry in ChangeTracker.Entries<Car>())
            {
                if (entry.State == EntityState.Deleted)
                {
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                }
            }

            return base.SaveChanges();
        }
    }
}