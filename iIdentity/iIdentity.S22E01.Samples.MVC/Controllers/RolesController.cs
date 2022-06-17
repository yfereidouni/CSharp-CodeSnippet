using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace iIdentity.S22E01.Samples.MVC.Controllers;

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
}
