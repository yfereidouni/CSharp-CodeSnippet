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
            var user = new CreateViewModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }
            return View(model);
        }
    }
}
