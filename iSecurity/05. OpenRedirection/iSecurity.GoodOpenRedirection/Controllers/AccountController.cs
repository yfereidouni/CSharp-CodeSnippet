using Microsoft.AspNetCore.Mvc;

namespace iSecurity.GoodOpenRedirection.Controllers
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
           
            ///Incorrect-way
            return Redirect(loginModel.ReturnUrl);
            
            ///Correct-Way
            //return LocalRedirect(loginModel.ReturnUrl);
        }


    }
}
