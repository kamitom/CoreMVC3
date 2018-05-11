using CoreMVC3.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMVC3.Data
{
    public class DutchContext: DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }
    }
}