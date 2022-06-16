using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA;

public class AAADbContext : IdentityDbContext<IdentityUser>
{
    public AAADbContext(DbContextOptions<AAADbContext> options) : base(options)
    {
    }

}
