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
                await httpcontext.Response.WriteAsync("1st-Middleware Executing... => ");
            }
            await next();

            // In-Return-Way
            if (httpcontext.Request.Query.ContainsKey("AddText"))
                await httpcontext.Response.WriteAsync("1st-Middleware Executed.  => ");
        });

        app.Use(async (httpcontext, next) =>
        {
            if (httpcontext.Request.Query.ContainsKey("AddText"))
            {
                await httpcontext.Response.WriteAsync("2nd-Middleware Executing...  => ");
            }
            await next();

            // In-Return-Way
            if (httpcontext.Request.Query.ContainsKey("AddText"))
                await httpcontext.Response.WriteAsync("2nd-Middleware Executed.  => ");
        });


        app.UseMiddleware<MyFirstMiddleware>();

        app.MapGet("/", () => "Hello World!");

        return app;
    }
}
