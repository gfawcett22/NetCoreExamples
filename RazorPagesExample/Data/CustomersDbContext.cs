using Microsoft.EntityFrameworkCore;
using RazorPagesExample.Models;

namespace RazorPagesExample.Data
{
    public class CustomersDbContext : DbContext
    {
        public CustomersDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}