using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S23E06.AuthNAuthZ.Controllers
{
    public class UsersController : Controller
    {
        //private readonly UserManager<IdentityUser> userManager; 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        //public UsersController(UserManager<IdentityUser> userManager)
        public UsersController(UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var users = userManager.Users.ToList();
            return View(users);
        }

        [Authorize("AgeGraterThan21")]
        [Authorize("AdminUsers")]
        [Authorize("GoldPartner")]
        public IActionResult Create()
        {
            var user = new CreateUserModel();
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserModel model)
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

        public async Task<IActionResult> EditUserRoles(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var userRoles = await userManager.GetRolesAsync(user);
            var roles = roleManager.Roles.ToList();

            var model = new EditUserRolesViewModel()
            {
                UserName = user.UserName,
                UserId = user.Id,
                Roles = roles,
                UserRoles = userRoles.ToList()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditUserRoles(string userId, List<string> roles)
        {
            var user = await userManager.FindByIdAsync(userId);
            var currentRoles = await userManager.GetRolesAsync(user);

            foreach (var role in currentRoles)
            {
                if (!roles.Any(c => c == role))
                {
                    var removeRoleResult = await userManager.RemoveFromRoleAsync(user, role);
                }
            }
            foreach (var role in roles)
            {
                var isInRole = await userManager.IsInRoleAsync(user, role);
                if (!isInRole)
                {
                    var addToRoleResult = await userManager.AddToRoleAsync(user, role);
                }
            }

            return RedirectToAction("Index", "Users");
        }
    }
}
