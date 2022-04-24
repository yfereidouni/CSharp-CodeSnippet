using Microsoft.EntityFrameworkCore;

namespace iEFCore.TablePerType;

public class TptDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    //public DbSet<Student> Students { get; set; }
    //public DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=TablePerType_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>().ToTable("Teachers");
        modelBuilder.Entity<Student>().ToTable("Students");
    }

}
