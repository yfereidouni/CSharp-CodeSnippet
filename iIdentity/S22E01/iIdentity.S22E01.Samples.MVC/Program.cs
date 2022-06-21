using iIdentity.S22E01.Samples.MVC.Models.AAA.Data;
using iIdentity.S22E01.Samples.MVC.Models.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//YFereidouni -------------------------------------------------------------
builder.Services.AddDbContext<AAADbContext>(options => options
                .UseSqlServer(builder.Configuration.GetConnectionString("AAACnn")));

//builder.Services.AddIdentity<IdentityUser, IdentityRole>(c =>
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(c =>
{
    c.Password.RequireDigit = false;
    c.Password.RequireUppercase = false;
    c.Password.RequireLowercase = false;
    c.Password.RequiredLength = 3;
    c.Password.RequireNonAlphanumeric = false;
    c.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    c.User.RequireUniqueEmail = true;

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
builder.Services.AddTransient<IPasswordValidator<ApplicationUser>, UsernameNotInPasswordValidator>();
builder.Services.AddTransient<IPasswordValidator<ApplicationUser>, BadPasswordValidator>();
builder.Services.AddTransient<IUserValidator<ApplicationUser>, CustomeUserValidator>();
//builder.Services.AddTransient<IPasswordValidator<IdentityUser>, UsernameNotInPasswordValidator>();
//builder.Services.AddTransient<IPasswordValidator<IdentityUser>, BadPasswordValidator>();
//builder.Services.AddTransient<IUserValidator<IdentityUser>, CustomeUserValidator>();



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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
