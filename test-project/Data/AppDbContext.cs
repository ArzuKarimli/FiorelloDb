using Microsoft.EntityFrameworkCore;
using test_project.Models;

namespace test_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
      

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfo { get; set;}
  
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SupriseVideo> SupriseVideo { get; set; }
        public DbSet<SupriseInfo> SupriseInfos { get; set; }
        public DbSet<InfosItem> InfoItems { get; set; }

        public DbSet<Expert> Experts { get; set; }
        public DbSet<Position> Positions { get; set; }

    }
}
