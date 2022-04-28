using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E11.FromSQLInterpolated;

public class FromSQLInterpolatedDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<NewsSummary> Summaries { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E11.FromSQLInterpolatedDbContext_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>().HasData(new Teacher[]
        {
            new Teacher
            {
                Id = 1,
                FirstName = "Yasser",
                LastName ="Fereidouni"
            },
            new Teacher
            {
                Id = 2,
                FirstName = "Alireza",
                LastName ="Oroumand"
            },

        });
        modelBuilder.Entity<News>().HasData(new News
        {
            Id = 1,
            Title = "Title01",
            ImageUrl ="Image01",
            NewsBody ="NewsBody01",
            ShortDescription = "ShortDesc01",
            RootTitr = "RootTitr01"
        });

        modelBuilder.Entity<Teacher>()
                    .HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangedNotifications);

        modelBuilder.Entity<NewsSummary>().ToSqlQuery("SELECT * FROM News");
    }
}

