using Microsoft.EntityFrameworkCore;
using SimpleManager.Domain.Entities;
using Microsoft.EntityFrameworkCore.Design; 

namespace SimpleManager.Infrastructure
{
    public class Data :DbContext
    {
        public Data(DbContextOptions<Data> options) : base(options) { }
        public DbSet<User> Users => Set<User>();
        public DbSet<Category> Categories => Set<Category>();
        public DbSet<Products> Products => Set<Products>();
        public DbSet<ProductImage> ProductImages => Set<ProductImage>();
        public DbSet<Inventory> Inventories => Set<Inventory>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(x => x.Email)
                .IsUnique();

            modelBuilder.Entity<Products>()
                .HasOne(p => p.Inventory)
                .WithOne(i => i.Product)
                .HasForeignKey<Inventory>(i => i.ProductId);

            modelBuilder.Entity<ProductImage>()
                .HasIndex(i => new { i.ProductId, i.IsMain });
        }
    }
}
