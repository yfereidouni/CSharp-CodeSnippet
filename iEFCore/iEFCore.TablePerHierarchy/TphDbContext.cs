using Microsoft.EntityFrameworkCore;

namespace iEFCore.TablePerHierarchy;

public class TphDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=TablePerHierarchy_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(c =>
        {
            c.HasDiscriminator<int>("Disc")
                .HasValue<Person>(1)
                .HasValue<Student>(2)
                .HasValue<Teacher>(3);
        });
    }

}
