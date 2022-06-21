using Microsoft.AspNetCore.Identity;
using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;

namespace iIdentity.S23E06.AuthNAuthZ.Models.Services;

//public class BadPasswordValidator : IPasswordValidator<IdentityUser>
public class BadPasswordValidator : IPasswordValidator<ApplicationUser>
{
    private readonly AAADbContext context;

    public BadPasswordValidator(AAADbContext context)
    {
        this.context = context;
    }
    public async Task<IdentityResult> ValidateAsync(
            UserManager<ApplicationUser> manager, ApplicationUser user, string password)
    {
        var errors = new List<IdentityError>();

        var isInBadPasswordList = context.BadPasswords.Any(c => c.BadPasswordText == password);

        if (isInBadPasswordList)
        {
            errors.Add(new IdentityError
            {
                Code = "BadPassword",
                Description = "Your Password was marked as BadPassword!"
            });
        }
    
        return errors.Count == 0 ? 
            IdentityResult.Success : 
            IdentityResult.Failed(errors.ToArray());
    }
}