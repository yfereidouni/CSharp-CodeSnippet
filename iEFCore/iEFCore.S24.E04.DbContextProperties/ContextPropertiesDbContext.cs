using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E04.DbContextProperties;

public class ContextPropertiesDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E04.ContextProperties_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
}
