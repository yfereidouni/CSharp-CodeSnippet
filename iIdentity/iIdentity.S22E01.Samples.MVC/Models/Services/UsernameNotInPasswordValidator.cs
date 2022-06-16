using Microsoft.AspNetCore.Identity;

namespace iIdentity.S22E01.Samples.MVC.Models.Services
{
    public class UsernameNotInPasswordValidator : IPasswordValidator<IdentityUser>
    {
        public async Task<IdentityResult> ValidateAsync(
            UserManager<IdentityUser> manager, IdentityUser user, string password)
        {
            var errors = new List<IdentityError>();

            if (password.Contains(user.UserName))
            {
                errors.Add(new IdentityError
                {
                    Code = "UsernameIsInPassword",
                    Description = "Username should not be in the password."
                });
            }
            return errors.Count == 0 ? IdentityResult.Success : IdentityResult.Failed(errors.ToArray());
        }
    }
}
