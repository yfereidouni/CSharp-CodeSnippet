using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);


JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
builder.Services.AddAuthentication(option =>
{
    option.DefaultScheme = "Cookies";
    option.DefaultChallengeScheme = "oidc";
})
.AddCookie("Cookies")
.AddOpenIdConnect("oidc", options =>
{
    options.Authority = "https://localhost:5001";

    options.ClientId = "mvc";
    options.ClientSecret = "secret";
    options.ResponseType = "code";
    options.Scope.Add("profile");
    options.GetClaimsFromUserInfoEndpoint = true;
    options.SaveTokens = true;
    options.Scope.Add("api1");
    //options.Scope.Add("offline_access");
});

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}").RequireAuthorization();

app.Run();
