using iCourseStore.BLL;
using iCourseStore.DAL.CourseStoreDB;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();


//builder.Services.AddDbContext<CourseStoreDbContext>(options => options
//                .UseSqlServer("Server=.;Initial Catalog=iCourseStore_DB;Integrated Security=True;Encrypt=false;"));

builder.Services.AddDbContext<CourseStoreDbContext>(options => options
                .UseSqlServer(builder.Configuration
                .GetConnectionString("iCourseStore_DB"))
                .LogTo(message => Debug.WriteLine(message)));

builder.Services.AddScoped<CourseServices>();

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

app.UseAuthorization();

//app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
