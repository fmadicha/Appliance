using Appliance.Models;
using Microsoft.EntityFrameworkCore;

namespace Appliance.Data
{
    public class ApplianceDbContext:DbContext
    {
        public ApplianceDbContext(DbContextOptions<ApplianceDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
