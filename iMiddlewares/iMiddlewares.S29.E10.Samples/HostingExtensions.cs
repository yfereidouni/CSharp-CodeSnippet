namespace iMiddlewares.S29.E10.Samples;

public static class HostingExtensions
{
    public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
    {
        return builder.Build();
    }

    public static WebApplication ConfigurePipeLine(this WebApplication app)
    {
        app.Use(async (httpcontext, next) =>
        {
            if (httpcontext.Request.Query.ContainsKey("AddText"))
            {
                httpcontext.Response.ContentType = "text/html";
                await httpcontext.Response.WriteAsync("Hello from 1st-Middleware -> ");
            }
            await next();
        });

        app.Use(async (httpcontext, next) =>
        {
            if (httpcontext.Request.Query.ContainsKey("AddText"))
            {
                await httpcontext.Response.WriteAsync("Hello from 2nd-Middleware -> ");
            }
            await next();
        });


        app.UseMiddleware<MyFirstMiddleware>();

        app.MapGet("/", () => "Hello World!");

        return app;
    }
}
