using Microsoft.AspNetCore.Identity;

namespace iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

public class EditUserRolesViewModel
{
    public string UserName { get; set; }
    public string UserId { get; set; }
    public List<string> UserRoles { get; set; }
    public List<IdentityRole> Roles { get; set; }
}
