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
        public DbSet<ThoiGianSuDungThietBi> ThoiGianSuDungThietBis { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ezbooking.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set default value for CreatedAt and IsDeleted
            modelBuilder.Entity<ThoiGianBieu>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
                entity.HasQueryFilter(e => !e.IsDeleted);
            });

            modelBuilder.Entity<DichVuKT>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<BacSiKTV>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<BenhNhan>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
                entity.HasQueryFilter(e => !e.IsDeleted);
            });

            modelBuilder.Entity<ThietBi>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<ThoiGianSuDungThietBi>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasDefaultValueSql("CURRENT_TIMESTAMP");
                entity.Property(e => e.IsDeleted).HasDefaultValue(false);
            });
        }
    }
}

