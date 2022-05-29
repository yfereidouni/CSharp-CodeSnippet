namespace iMiddlewares.S29.E10.Samples;

public class MySecondMiddleware
{
    private readonly RequestDelegate next;

    public MySecondMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Response.ContentType = "text/html";

        await context.Response.WriteAsync("My-Second-MiddleWare-Class Executing...  => ");

        await next(context);

        await context.Response.WriteAsync("My-Second-MiddleWare-Class Executed.  => ");
    }
}
