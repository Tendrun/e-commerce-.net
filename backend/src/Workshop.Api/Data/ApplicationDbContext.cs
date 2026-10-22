using Microsoft.EntityFrameworkCore;
using Workshop.Api.Features.Product;

namespace Workshop.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProductEntity>(entity => {
                entity.HasKey(k => k.Id);
                entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Price).IsRequired().HasPrecision(18, 2);
                entity.Property(p => p.Stock).IsRequired();
                entity.Property(p => p.CreatedAt).IsRequired();
            });
        }
    }
}
