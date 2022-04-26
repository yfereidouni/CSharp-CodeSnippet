using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E12.DefaultValue;

public class DefaultValueDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E12.DefaultValue_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Default Value
        modelBuilder.Entity<Person>()
                    .Property(c => c.RegisterDate)
                    .HasDefaultValueSql("GetDate()");

        modelBuilder.Entity<Person>()
                    .Property(c => c.Age)
                    .HasDefaultValue(100);

    }
}
