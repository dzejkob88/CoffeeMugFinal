using Microsoft.EntityFrameworkCore;
using CoffeeMug.Models;

namespace CoffeeMug.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext (DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
