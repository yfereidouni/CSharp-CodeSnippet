using Microsoft.EntityFrameworkCore;

namespace iEFCore.RelationConfigurationExtera.OwnedTypeSample;

public class OwnedTypeDbContext : DbContext
{
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=OwnedTypes_DB;User Id=dbuser; Password=1qaz!QAZ;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Person>(person =>
        {
            person.OwnsOne(person => person.Address);
            person.OwnsOne(c => c.Car).ToTable("Cars");
            person.OwnsMany(m => m.Money).ToTable("Money");
        });
       
        modelBuilder.Entity<Person>(p =>
        {
            p.HasData(new
            {
                Id = 1,
                FirstName = "Yasser",
                LastName = "Fereidouni",
            });

            p.OwnsOne(e => e.Address).HasData(new
            {
                PersonId = 1,
                City = "Karaj",
                Street = "1st Dehghanvilla",
            });

            p.OwnsOne(c => c.Car).HasData(new 
            {
                PersonId = 1,
                CarName = "Persia"
            });
            p.OwnsMany(m => m.Money).HasData(new 
            {
                 PersonId = 1,
                 Id = 1,
                 Value=1000
            });
            p.OwnsMany(m => m.Money).HasData(new
            {
                PersonId = 1,
                Id = 2,
                Value = 5000
            });
        });
    }
}

