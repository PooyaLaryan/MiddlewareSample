
namespace MiddlewareSample
{
    public class CustomMiddleware2 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("CustomMiddleware2 before");
            await next(context);
            await context.Response.WriteAsync("CustomMiddleware2 after");
        }
    }

    public static class Extention
    {
        public static IApplicationBuilder UseCustomMiddleware2(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomMiddleware2>();
        }
    }
}
