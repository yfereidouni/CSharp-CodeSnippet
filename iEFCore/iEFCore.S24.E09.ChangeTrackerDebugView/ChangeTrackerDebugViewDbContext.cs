using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E09.ChangeTrackerDebugView;

public class ChangeTrackerDebugViewDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E09.ChangeTrackerDebugView_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>().HasData(new Teacher
        {
            Id = 1,
            FirstName = "Yasser",
            LastName ="Fereidouni"
        });

        modelBuilder.Entity<Teacher>()
                    .HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangedNotifications);
    }
}

