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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
