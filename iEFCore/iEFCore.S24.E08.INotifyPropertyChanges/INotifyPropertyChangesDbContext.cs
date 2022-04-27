using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E08.INotifyPropertyChanges;

public class INotifyPropertyChangesDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E08.INotifyPropertyChanges_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Teacher>()
                    .HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangedNotifications);
        modelBuilder.Entity<Course>()
                    .HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangingAndChangedNotificationsWithOriginalValues);
    }
}

