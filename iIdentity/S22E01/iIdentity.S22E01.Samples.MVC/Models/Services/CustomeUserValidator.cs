using iIdentity.S22E01.Samples.MVC.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;

namespace iIdentity.S22E01.Samples.MVC.Models.Services;

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

