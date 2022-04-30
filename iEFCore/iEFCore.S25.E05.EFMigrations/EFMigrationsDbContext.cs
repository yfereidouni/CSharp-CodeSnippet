using iEFCore.S25.E05.EFMigrations.MyMigrationOperation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iEFCore.S25.E05.EFMigrations;

public class EFMigrationsDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Initial Catalog=S25.E05.EFMigrations_DB;User Id=dbuser; Password=1qaz!QAZ;", c =>
        {
            c.MigrationsHistoryTable("MyAppMigrationHistory");
        });

        //.ReplaceService<IMigrationsSqlGenerator, MySqlMigrationgenerator>();


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //حذف مدل از فرآیند مهاجرت دیتابیس
        modelBuilder.Entity<Car>().ToTable("Cars", c => c.ExcludeFromMigrations());
        modelBuilder.Entity<Book>().ToTable("Books", c => c.ExcludeFromMigrations());
    }
}

