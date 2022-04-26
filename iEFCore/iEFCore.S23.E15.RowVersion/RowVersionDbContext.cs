using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E15.RowVersion;

public class RowVersionDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E15.RowVersion_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().Property(c=>c.FirstName).IsConcurrencyToken();
        modelBuilder.Entity<Product>().Property(c=>c.RowVersion).IsConcurrencyToken();
    }
}
