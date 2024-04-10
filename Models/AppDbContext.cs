using Microsoft.EntityFrameworkCore;

namespace ezbooking.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<ThoiGianBieu> ThoiGianBieus { get; set; }
        public DbSet<DichVuKT> DichVuKTs { get; set; }
        public DbSet<BacSiKTV> BacSiKTVs { get; set; }
        public DbSet<BenhNhan> BenhNhans { get; set; }
        public DbSet<ThietBi> ThietBis { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ezbooking.db");
        }
    }
}

