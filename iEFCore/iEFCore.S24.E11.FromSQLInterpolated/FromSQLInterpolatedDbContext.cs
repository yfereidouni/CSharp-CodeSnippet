using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E11.FromSQLInterpolated;

public class FromSQLInterpolatedDbContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
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

        modelBuilder.Entity<Teacher>()
                    .HasChangeTrackingStrategy(ChangeTrackingStrategy.ChangedNotifications);
    }
}

