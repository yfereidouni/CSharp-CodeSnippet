using Microsoft.EntityFrameworkCore;

namespace iEFCore.ManyToMany.ManyToManySample;

public class ManyToManyDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Tag> Tags { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=ManyToMany_DB; User Id=dbuser; Password=1qaz!QAZ");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(c =>
        {
            c.HasMany(c => c.Tags).WithMany(d => d.Products).UsingEntity<PTRelationEntity>(
                p => p.HasOne(d => d.Tag).WithMany().HasForeignKey(d => d.TagId),
                t => t.HasOne(d => d.Product).WithMany().HasForeignKey(d => d.ProductId));
        });
    }
}
