using Microsoft.EntityFrameworkCore;

namespace iEFCore.OneToOne.OneToOneSample;

public class OneToOneDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Discount> Discounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=OneToOne_DB; User Id=dbuser; Password=1qaz!QAZ");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(c =>
        {
            c.HasOne(c=>c.Discount).WithOne().HasForeignKey<Discount>(c=>c.ProductId);
        });
    }
}