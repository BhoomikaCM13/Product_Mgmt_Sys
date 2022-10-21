using Entity_Layer;
using Microsoft.EntityFrameworkCore;
using System;

namespace Product_Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
       public DbSet<Article> Articles { get; set; }
       public DbSet<Color> Colors { get; set; }
       public DbSet<Size> Sizes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2126;Initial Catalog=ProductAPI;Integrated Security=True;");
        }
    }
}
