using Microsoft.EntityFrameworkCore;

namespace iEFCore.OneToMany.OneToManySample
{
    public class OneToManyDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=OneToMany_DB; User Id=dbuser; Password=1qaz!QAZ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(c =>
            {
                c.HasMany(c => c.Comments).WithOne().HasForeignKey(c => c.ProductId);
            });
        }
    }
}
