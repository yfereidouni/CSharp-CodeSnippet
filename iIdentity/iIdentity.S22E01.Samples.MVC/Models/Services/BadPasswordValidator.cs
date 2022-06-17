using Microsoft.AspNetCore.Identity;
using iIdentity.S22E01.Samples.MVC.Models.AAA;

namespace iIdentity.S22E01.Samples.MVC.Models.Services;

public class BadPasswordValidator : IPasswordValidator<IdentityUser>
{
    private readonly AAADbContext context;

    public BadPasswordValidator(AAADbContext context)
    {
        this.context = context;
    }
    public async Task<IdentityResult> ValidateAsync(
            UserManager<IdentityUser> manager, IdentityUser user, string password)
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
    
        return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
    }
}

