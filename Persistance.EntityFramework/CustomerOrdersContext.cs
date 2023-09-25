using Microsoft.EntityFrameworkCore;
using RaneFattesingh.Persistance.EntityFramework.Entities;

namespace RaneFattesingh.Persistance.EntityFramework
{
    public class CustomerOrdersContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public CustomerOrdersContext(DbContextOptions<CustomerOrdersContext> options) : base(options)
        {
            // Empty
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().
                HasData(
                    new Customer
                    {
                        CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                        FirstName = "Alice",
                        LastName = "Smith",
                        DOB = new DateTime(1987, 1, 1)
                    },
                    new Customer
                    {
                        CustomerID = new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"),
                        FirstName = "Bob",
                        LastName = "Smith",
                        DOB = new DateTime(1986, 12, 12)
                    }
                );

            modelBuilder.Entity<Order>().
                HasData(
                    new Order
                    {
                        OrderID = 1,
                        CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                        ItemName = "Nail Polish",
                        ItemPrice = 100.00
                    },
                    new Order
                    {
                        OrderID = 2,
                        CustomerID = new Guid("481cf36a-fdb8-4911-853f-34ad26df4a2a"),
                        ItemName = "Hair Brush",
                        ItemPrice = 500.00
                    },
                    new Order
                    {
                        OrderID = 3,
                        ItemName = "Shaving Cream",
                        CustomerID = new Guid("1db7a052-91d5-43f0-8eeb-c852b504cd59"),
                        ItemPrice = 90.00
                    }
                );
        }
    }
}
