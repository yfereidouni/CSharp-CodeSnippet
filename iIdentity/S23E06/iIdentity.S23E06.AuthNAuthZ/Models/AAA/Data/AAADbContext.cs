using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

//public class AAADbContext : IdentityDbContext<IdentityUser>
public class AAADbContext : IdentityDbContext<ApplicationUser>
{
    public DbSet<BadPassword> BadPasswords { get; set; }
    public AAADbContext(DbContextOptions<AAADbContext> options) : base(options)
    {
    }
}
