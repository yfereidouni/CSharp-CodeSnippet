using Microsoft.EntityFrameworkCore;

namespace iEFCore.S22.E24.TableSplitting;

public class TableSplittingDbContext : DbContext
{
    public DbSet<News> News { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S22.E24.TableSplitting_DB;User Id=dbuser; Password=1qaz!QAZ;");

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<News>(c =>
        {
            c.HasOne(c => c.NewsDetail).WithOne().HasForeignKey<NewsDetail>(c => c.Id);
            c.ToTable("News");
        });
        modelBuilder.Entity<NewsDetail>().ToTable("News");
    }

}
