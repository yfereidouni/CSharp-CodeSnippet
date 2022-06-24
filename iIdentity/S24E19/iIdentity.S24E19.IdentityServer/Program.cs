using iIdentity.S24E19.IdentityServer;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

//https://localhost:7166/.well-known/openid-configuration
builder.Services.AddIdentityServer()
                .AddInMemoryIdentityResources(Config.IdentityResources)
                .AddInMemoryApiScopes(Config.ApiScopes)
                .AddInMemoryClients(Config.Clients)
                .AddTestUsers(TestUsers.Users);
                


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
    .MinimumLevel.Override("System", LogEventLevel.Warning)
    .MinimumLevel.Override("Microsoft.AspNetCore.Authentication", LogEventLevel.Information)
    .Enrich.FromLogContext()

    .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:1j}{NewLine}{Exception}{NewLine}", theme: AnsiConsoleTheme.Code)
    .CreateLogger();

try
{
    Log.Information("Starting host.....");
    //CreateHostBuilder(args).Build().Run();
    //return 0;
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly.");
    //return 1;
}
finally
{
    Log.CloseAndFlush();
}

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseIdentityServer();

//app.MapGet("/", () => "Duende-Identity-Server was running!");

app.UseEndpoints(c =>
{
    c.MapRazorPages().RequireAuthorization();
});

app.Run();

