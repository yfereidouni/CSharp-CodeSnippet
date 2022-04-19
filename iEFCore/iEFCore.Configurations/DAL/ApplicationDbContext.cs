using iEFCore.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace iEFCore.Configurations.DAL
{
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new PrimaryKeyFluentConfiguration());
            modelBuilder.ApplyConfiguration(new ReadOnlyFluentConfiguration());
            modelBuilder.ApplyConfiguration(new IndexUsingFluentAPIConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
