using iSecurity.SqlInjection.Entities;
using Microsoft.EntityFrameworkCore;

namespace iSecurity.SqlInjection.Data
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Customers.Any())
                {
                    return;
                }

                var customers = new List<Customer>() 
                {
                    new Customer
                    {
                        FirstName = "Yasser",
                        Lastname = "Fereidouni"
                    },
                    new Customer
                    {
                        FirstName = "Farid",
                        Lastname = "Taheri"
                    },
                    new Customer
                    {
                        FirstName = "Masoud",
                        Lastname = "Taheri"
                    },
                    new Customer
                    {
                        FirstName = "Meysam",
                        Lastname = "Taghvaei"
                    },
                    new Customer
                    {
                        FirstName = "Shervin",
                        Lastname = "Souri"
                    },
                };

                await context.Customers.AddRangeAsync(customers);
                await context.SaveChangesAsync();
            }

        }
    }
}
