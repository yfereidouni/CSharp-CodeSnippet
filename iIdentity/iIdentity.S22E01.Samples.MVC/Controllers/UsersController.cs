using iIdentity.S22E01.Samples.MVC.Models.AAA;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S22E01.Samples.MVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }

        public IActionResult Create()
        {
            var user = new UserViewModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(string userName, string email, string password)
        {
            var user = new IdentityUser() 
            {
                UserName = userName,
                Email = email,
                PasswordHash = password,
                EmailConfirmed = true
            };
            await userManager.CreateAsync(user);
            return RedirectToAction("Index");
        }
    }
}
