using System.Linq;
using RazorPagesExample.Models;

namespace RazorPagesExample.Data
{
    public static class CustomersInitializer
    {
        public static void Initialize(CustomersDbContext context)
        {
            if (context.Customers.Any())
            {
                return;
            }
            var customers = new Customer[]
            {
                new Customer {Name = "Customer 1", Address = "123 Cherry St.", Country = "China"},
                new Customer {Name = "Customer 2", Address = "321 Grape St.", Country = "USA"},
                new Customer {Name = "Customer 3", Address = "123 Plum St.", Country = "Japan"},
                new Customer {Name = "Customer 4", Address = "123 Apple St.", Country = "Germany"},
                new Customer {Name = "Customer 5", Address = "123 Blueberry St.", Country = "UK"}
            };
            
            context.Customers.AddRange(customers);
            context.SaveChanges();
        }
    }
}