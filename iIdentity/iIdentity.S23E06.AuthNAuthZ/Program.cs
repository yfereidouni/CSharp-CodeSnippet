using iIdentity.S23E06.AuthNAuthZ.Models.AAA.Data;
using iIdentity.S23E06.AuthNAuthZ.Models.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;



var builder = WebApplication.CreateBuilder(args);

//Define Policy for Authorization ------------------------------------------------------
builder.Services.AddAuthorization(c =>
{
    c.AddPolicy("AdminUsers", c =>
    {
        //c.RequireRole("admin");
        c.Requirements.Add(new UserInRoleRequirement("admin"));
        c.Requirements.Add(new UserInRoleRequirement("admin1"));
        c.Requirements.Add(new UserInRoleRequirement("admin2"));
    });
});

builder.Services.AddSingleton<IAuthorizationHandler, UserInRoleRequirementHandler2>();
builder.Services.AddSingleton<IAuthorizationHandler, UserInRoleRequirementHandler1>();
builder.Services.AddSingleton<IAuthorizationHandler, UserInRoleRequirementHandler>();
//--------------------------------------------------------------------------------------

// Add services to the container.
builder.Services.AddControllersWithViews();

//YFereidouni -------------------------------------------------------------
builder.Services.AddDbContext<AAADbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("AAACnn")));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>(c =>
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(c =>
{
    //c.Password.RequireDigit = false;
    //c.Password.RequireUppercase = false;
    //c.Password.RequireLowercase = false;
    //c.Password.RequiredLength = 3;
    //c.Password.RequireNonAlphanumeric = false;
    //c.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //c.User.RequireUniqueEmail = true;

}).AddEntityFrameworkStores<AAADbContext>();

// Way-2: configuration of IdentityOptions
//builder.Services.Configure<IdentityOptions>(c => 
//{
//    c.Password.RequireDigit = false;
//    c.Password.RequireUppercase = false;
//    c.Password.RequireLowercase = false;
//    c.Password.RequiredLength = 3;
//});

//Username & Password Custom validators
//builder.Services.AddTransient<IPasswordValidator<ApplicationUser>, UsernameNotInPasswordValidator>();
//builder.Services.AddTransient<IPasswordValidator<ApplicationUser>, BadPasswordValidator>();
//builder.Services.AddTransient<IUserValidator<ApplicationUser>, CustomeUserValidator>();
////builder.Services.AddTransient<IPasswordValidator<IdentityUser>, UsernameNotInPasswordValidator>();
////builder.Services.AddTransient<IPasswordValidator<IdentityUser>, BadPasswordValidator>();
////builder.Services.AddTransient<IUserValidator<IdentityUser>, CustomeUserValidator>();



var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AAADbContext>();
    context.Database.Migrate();
    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//Should be place here -------------
app.UseAuthentication();
//----------------------------------

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//Requirement & RequirementHandler for Add-Policy -------------------------
public class UserInRoleRequirement : IAuthorizationRequirement
{
    public UserInRoleRequirement(string role)
    {
        Role = role;
    }
    public string Role { get; }
}
public class UserInRoleRequirementHandler : AuthorizationHandler<UserInRoleRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserInRoleRequirement requirement)
    {
        //if (context.User.IsInRole(requirement.Role))
        if (context.User.IsInRole("admin"))
        {
            context.Succeed(requirement);
        }
        return Task.CompletedTask;
    }
}
public class UserInRoleRequirementHandler1 : AuthorizationHandler<UserInRoleRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserInRoleRequirement requirement)
    {
        if (context.User.IsInRole("admin1"))
        {
            context.Succeed(requirement);
        }
        return Task.CompletedTask;
    }
}
public class UserInRoleRequirementHandler2 : AuthorizationHandler<UserInRoleRequirement>
{
    protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserInRoleRequirement requirement)
    {
        //if (context.User.IsInRole(requirement.Role))
        if (context.User.IsInRole("admin2"))
        {
            context.Succeed(requirement);
        }
        return Task.CompletedTask;
    }
}
//-------------------------------------------------------------------------
