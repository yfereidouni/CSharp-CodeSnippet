using iSecurity.SqlInjection.Entities;
using Microsoft.EntityFrameworkCore;

namespace iSecurity.SqlInjection.Data
{
    public class SeedData
    {
        public static async Task Initialize(IServiceProvider serviceProvider, string password)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                var customer = new Customer { FirstName = "Yasser", Lastname = "Fereidouni" };
                
                customer.save


                // administrator
                var adminUid = await EnsureUser(serviceProvider, "admin@test.com", password);
                await EnsureRole(serviceProvider, adminUid, Constants.InvoiceAdminRole);

            }

        }
    }
}
