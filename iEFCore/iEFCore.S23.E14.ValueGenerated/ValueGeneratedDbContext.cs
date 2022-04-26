using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E14.ValueGenerated;

public class ValueGeneratedDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E14.ValueGenerated_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>()
                    .Property(c => c.FullName)
                    .HasComputedColumnSql("FirstName+ ' ' + LastName", true);

        modelBuilder.Entity<Person>().Property(c=>c.FullName).ValueGeneratedOnAdd();
    }
}
