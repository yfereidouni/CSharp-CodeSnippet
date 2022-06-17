using Microsoft.AspNetCore.Identity;

namespace iIdentity.S22E01.Samples.MVC.Models.Services;

public class CustomeUserValidator : IUserValidator<IdentityUser>
{
    public async Task<IdentityResult> ValidateAsync(UserManager<IdentityUser> manager, IdentityUser user)
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

