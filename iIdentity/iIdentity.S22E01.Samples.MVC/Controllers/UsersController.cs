using iIdentity.S22E01.Samples.MVC.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S22E01.Samples.MVC.Controllers
{
    public class UsersController : Controller
    {
        //private readonly UserManager<IdentityUser> userManager; 
        private readonly UserManager<ApplicationUser> userManager;

        //public UsersController(UserManager<IdentityUser> userManager)
        public UsersController(UserManager<ApplicationUser> userManager)
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
                //var user = new IdentityUser()
                var user = new ApplicationUser()
                {
                    UserName = model.Username,
                    Email = model.Email,
                    SSN = model.SSN,
                };

                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    TempData["Message"] = "User Created!";
                    return RedirectToAction("Index", "Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            var errors = new List<IdentityError>();

            var user = await userManager.FindByIdAsync(id);
            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                TempData["Message"] = "User Removed!";
            }
            else
            {
                TempData["Message"] = "Action failed!";
            }

            return RedirectToAction("Index", "Users");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                var dbUser = await userManager.FindByIdAsync(applicationUser.Id);

                dbUser.UserName = applicationUser.UserName;
                dbUser.Email = applicationUser.Email;
                dbUser.SSN = applicationUser.SSN;
                
                var result = await userManager.UpdateAsync(dbUser);


                if (result.Succeeded)
                {
                    TempData["Message"] = "User Updated!";
                    return RedirectToAction("Index", "Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
            }

            return View(applicationUser);
        }


    }
}
