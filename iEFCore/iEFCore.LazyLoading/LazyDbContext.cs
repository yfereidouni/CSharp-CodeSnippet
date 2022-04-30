using Microsoft.EntityFrameworkCore;

namespace iEFCore.LazyLoading;

public class LazyDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public LazyDbContext(DbContextOptions<LazyDbContext> options) : base(options)
    {
    }
}
