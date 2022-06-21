using iIdentity.S24E19.IdentityServer;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityServer()
                .AddInMemoryApiScopes(Config.ApiScopes)
                .AddInMemoryClients(Config.Clients);


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
    .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
    .MinimumLevel.Override("System", LogEventLevel.Warning);
    .MinimumLevel.Override("Microsoft.AspNetCore.Authentication")
    .Enrich.FormLogContext()




var app = builder.Build();

app.UseIdentityServer();

//app.MapGet("/", () => "Hello World!");

app.Run();
