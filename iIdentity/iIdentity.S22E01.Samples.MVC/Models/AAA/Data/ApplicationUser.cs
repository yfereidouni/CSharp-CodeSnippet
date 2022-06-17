using Microsoft.AspNetCore.Identity;

namespace iIdentity.S22E01.Samples.MVC.Models.AAA.Data;

public class ApplicationUser : IdentityUser
{
    public string SSN { get; set; }
}
