using EFWebAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EFWebAPI.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) 
        {

        }

        public DbSet<Product> products { get; set; }


    }
}
