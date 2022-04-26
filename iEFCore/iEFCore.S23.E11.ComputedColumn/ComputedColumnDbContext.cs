using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E11.ComputedColumn;

public class ComputedColumnDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E11.ComputedColumn_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Computed Column
        modelBuilder.Entity<Person>()
                    .Property(c => c.FullName)
                    .HasComputedColumnSql("FirstName+ ' ' + LastName", true);

        //Default Value
        modelBuilder.Entity<Person>()
                    .Property(c => c.RegisterDate)
                    .HasDefaultValueSql("GetDate()");
        
        modelBuilder.Entity<Person>()
                    .Property(c => c.Age)
                    .HasDefaultValue(100);

    }
}
