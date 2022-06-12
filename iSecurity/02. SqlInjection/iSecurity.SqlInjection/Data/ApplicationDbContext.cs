using iSecurity.SqlInjection.Entities;
using Microsoft.EntityFrameworkCore;

namespace iSecurity.SqlInjection.Data
{
    public class ApplicationDbContext : DbContext
    {
        public  DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
