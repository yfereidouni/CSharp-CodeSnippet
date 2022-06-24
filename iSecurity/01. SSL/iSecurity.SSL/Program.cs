using NWebsec.AspNetCore.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

/// <summary>
/// Way-3 : Use builder.Services.AddHttpsRedirection 
/// </summary>
//builder.Services.AddHttpsRedirection(c =>
//{
//    c.HttpsPort = 5005;
//    c.RedirectStatusCode = 308; //Redirect Permanently
//});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

/// <summary>
/// Way-1 : Use [RequireHttps] attribute above the contro
/// Way-2 : Use app.UseHttpsRedirection(); to redirect to SSL version if it is available.
/// </summary>
app.UseHttpsRedirection();
///---------------------------------------------------------

app.UseStaticFiles();

/// <summary>
/// Way-5 : Settinh HSTS and preload with "using NWebsec.AspNetCore.Middleware;"
/// Preload-in : https://hstspreload.org/
/// </summary>
app.UseHsts(c => 
{
    c.MaxAge(minutes: 5);
    c.Preload();
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
