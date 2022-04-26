using Microsoft.EntityFrameworkCore;

namespace iEFCore.S23.E16.TemporalTable;

public class TemporalTableDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S23.E16.TemporalTable_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().ToTable(t => 
        {
            t.IsTemporal();
        });
    }
}
