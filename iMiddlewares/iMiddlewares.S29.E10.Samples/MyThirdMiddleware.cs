namespace iMiddlewares.S29.E10.Samples;

public class MyThirdMiddleware
{
    private readonly RequestDelegate next;

    public MyThirdMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        context.Response.ContentType = "text/html";

        await context.Response.WriteAsync("My-Third-MiddleWare-Class Executing...  => ");

        await next(context);

        await context.Response.WriteAsync("My-Third-MiddleWare-Class Executed.  => ");
    }
}