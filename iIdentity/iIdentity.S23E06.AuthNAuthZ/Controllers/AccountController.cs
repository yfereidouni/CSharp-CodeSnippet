using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S23E06.AuthNAuthZ.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(SignInManager<ApplicationUser> signInManager)
        {
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string? redirectUrl = "/")
        {
            //var redirectUrl = "/";
            var model = new LoginModel() { RedirectUrl = redirectUrl };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.UserName, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return LocalRedirect(model.RedirectUrl);
                }

                ModelState.AddModelError("", "Invalid Username or Password!");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return Redirect("/");
        }
    }
}
