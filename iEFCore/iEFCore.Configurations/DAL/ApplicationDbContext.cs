using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace iEFCore.Configurations.DAL;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.; Database=Configurations_DB; Integrated Security=True;");
    }
    public DbSet<Person> People { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<PrimaryKeyAttribute> PrimaryKeyAttributes { get; set; }
    public DbSet<PrimaryKeyFluent> PrimaryKeyFluents { get; set; }
    public DbSet<ReadOnlyAttribute> ReadOnlyAttributes { get; set; }
    public DbSet<IndexUsingAttribute> IndexUsingAttributes { get; set; }
    public DbSet<IndexUsingFluentAPI> IndexUsingFluentAPIs { get; set; }
    public DbSet<News> News { get; set; }
    public DbSet<BackingFieldSample> BackingFieldSamples { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (Database.IsSqlServer())
        {
            // Config For SQL Server
        }

        if (Database.IsRelational())
        {
            // Config for SQL Databases
        }
        else
        {
            // Config for No-SQL Databases
        }

        modelBuilder.ApplyConfiguration(new PersonConfiguration());
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
        modelBuilder.ApplyConfiguration(new PrimaryKeyFluentConfiguration());
        modelBuilder.ApplyConfiguration(new ReadOnlyFluentConfiguration());
        modelBuilder.ApplyConfiguration(new IndexUsingFluentAPIConfiguration());
        modelBuilder.ApplyConfiguration(new NewsConfiguration());
        modelBuilder.ApplyConfiguration(new BackingFieldSampleConfiguration());
        modelBuilder.HasDefaultSchema("dbo");
        base.OnModelCreating(modelBuilder);
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(200).AreUnicode(false);
    }
}
