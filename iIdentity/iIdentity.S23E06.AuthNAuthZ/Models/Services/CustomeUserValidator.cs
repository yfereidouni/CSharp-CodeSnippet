using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;

namespace iIdentity.S23E06.AuthNAuthZ.Models.Services;

public class CustomeUserValidator : IUserValidator<ApplicationUser>
{
    public async Task<IdentityResult> ValidateAsync(UserManager<ApplicationUser> manager, ApplicationUser user)
    {
        var errors = new List<IdentityError>();
        
        if (!user.Email.ToLower().EndsWith("@ehub.com".ToLower()))
        {
            errors.Add(new IdentityError
            {
                Code = "OrganizationEmailError",
                Description = "Please use @eHUB.COM email!"
            });
        }
        
        return errors.Count == 0 ?
            IdentityResult.Success :
            IdentityResult.Failed(errors.ToArray());
    }
}

