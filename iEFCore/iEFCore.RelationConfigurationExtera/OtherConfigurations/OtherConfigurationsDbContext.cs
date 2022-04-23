using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iEFCore.RelationConfigurationExtera.OtherConfigurations;

public class OtherConfigurationsDbContext : DbContext
{
    public DbSet<Parent> Parents { get; set; }
    public DbSet<Child> Children { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=OtherConfiguration_DB; User Id=dbuser; Password=1qaz!QAZ");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Parent>(c =>
        {
            c.HasMany(c => c.Children).WithOne().OnDelete(DeleteBehavior.Restrict);
            //c.HasMany(c => c.Children).WithOne().IsRequired();
            //c.HasMany(c => c.Children).WithOne().HasPrincipalKey(d => d.ParentCode).HasConstraintName("MY_CUSTOME_CONSTRAINT_NAME");
        });
    }
}
