using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructue.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}