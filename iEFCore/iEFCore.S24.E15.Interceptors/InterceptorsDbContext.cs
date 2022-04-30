using Microsoft.EntityFrameworkCore;

namespace iEFCore.S24.E15.Interceptors;

public class InterceptorsDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S24.E15.InterceptorsDbContext_DB;User Id=dbuser; Password=1qaz!QAZ;")
        .AddInterceptors(new AddAuditInterceptor());        
        //.AddInterceptors(new CancelTagedQueries());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>().HasData(new Person[]
        {
            new Person{
                Id = 1,
                FirstName = "Yasser",
                LastName ="Fereidouni"
            },
            new Person{
                Id = 2,
                FirstName = "Shervin",
                LastName ="Souri"
            },
        });

    }

    //public override int SaveChanges()
    //{
    //    ChangeTracker.AutoDetectChangesEnabled = false;
    //    AddAuditData();
    //    var result = base.SaveChanges();
    //    ChangeTracker.AutoDetectChangesEnabled = true;
    //    return result;
    //}

    private void AddAuditData()
    {
        ChangeTracker.DetectChanges();

        var added = ChangeTracker.Entries<IAuditable>().Where(c => c.State == EntityState.Added).ToList();
        foreach (var item in added)
        {
            item.Property(c => c.InsertDate).CurrentValue = DateTime.Now;
        }

        var modified = ChangeTracker.Entries<IAuditable>().Where(c => c.State == EntityState.Modified).ToList();
        foreach (var item in modified)
        {
            item.Property(c => c.UpdateDate).CurrentValue = DateTime.Now;
        }
    }
}

