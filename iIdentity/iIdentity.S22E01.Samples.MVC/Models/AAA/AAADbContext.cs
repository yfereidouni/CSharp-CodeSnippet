using iIdentity.S22E01.Samples.MVC.Models.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA;

public class AAADbContext : IdentityDbContext<IdentityUser>
{
    public DbSet<BadPassword> BadPasswords { get; set; }
    public AAADbContext(DbContextOptions<AAADbContext> options) : base(options)
    {
    }
}
