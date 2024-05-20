using BackendBeautyIconic.Models;
using Microsoft.EntityFrameworkCore;


    public class AppDbContext : DbContext
    {
        public DbSet<Users>? usuarios { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Favorites> favorites { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // ...
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura la cadena de conexión a tu base de datos PostgreSQL

            optionsBuilder.UseNpgsql("Host=localhost;Database=ProductStore;Username=postgres;Password=1098825894");
        }
    }
