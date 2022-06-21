using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S23E06.AuthNAuthZ.Controllers;

public class RolesController : Controller
{
    private readonly RoleManager<IdentityRole> roleManager;

    public RolesController(RoleManager<IdentityRole> roleManager)
    {
        this.roleManager = roleManager;
    }
    public IActionResult Index()
    {
        var roles = roleManager.Roles.ToList();
        return View(roles);
    }

    public IActionResult Create()
    {
        return View(new CreateRoleModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateRoleModel model)
    {
        if (ModelState.IsValid)
        {
            var role = new IdentityRole
            {
                Name = model.RoleName
            };

            var result = await roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                TempData["Message"] = "Role Created!";
                return RedirectToAction("Index", "Roles");
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
        var dbRole = await roleManager.FindByIdAsync(id);
        var result = await roleManager.DeleteAsync(dbRole);

        if (result.Succeeded)
        {
            TempData["Message"] = "Role Deleted!";
        }
        else
        {
            TempData["Message"] = "Action failed!";
        }

        return RedirectToAction("Index", "Roles");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var role = await roleManager.FindByIdAsync(id);

        return View(role);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(IdentityRole identityRole)
    {
        if (ModelState.IsValid)
        {
            var dbRole = await roleManager.FindByIdAsync(identityRole.Id);
            dbRole.Name = identityRole.Name;

            var result = await roleManager.UpdateAsync(dbRole);

            if (result.Succeeded)
            {
                TempData["Message"] = "Role Edited!";
                return RedirectToAction("Index", "Roles");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
        }
        return View(identityRole);
    }
}
