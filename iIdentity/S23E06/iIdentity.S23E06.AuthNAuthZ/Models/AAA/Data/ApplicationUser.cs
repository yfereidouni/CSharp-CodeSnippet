using Microsoft.AspNetCore.Identity;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

public class ApplicationUser : IdentityUser
{
    public string SSN { get; set; }
}
