namespace iMiddlewares.S29.E10.Samples;

public class MyFirstMiddleware
{
    private readonly RequestDelegate next;

    public MyFirstMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Query.ContainsKey("AddText"))
        {
            await context.Response.WriteAsync("Hello from My-First-MiddleWare-Class! -> ");
        }
        await next(context);
    }
}
