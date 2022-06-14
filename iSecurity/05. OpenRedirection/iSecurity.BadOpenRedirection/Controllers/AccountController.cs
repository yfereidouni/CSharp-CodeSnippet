using Microsoft.AspNetCore.Mvc;

namespace iSecurity.BadOpenRedirection.Controllers
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }

    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string returnUrl = "/")
        {
            return View(new LoginModel
            {
                ReturnUrl = returnUrl,
            });
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            //Login User Process....

            return Redirect("https://localhost:7038"); 

            //Prevent from this attack with using "LocalRedirect"
            //This ensure that your redirection perform locally in your domain not any other site.
            //return LocalRedirect(loginModel.ReturnUrl);
        }


    }
}
