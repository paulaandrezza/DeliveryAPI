namespace DeliveryAPI.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class SwaggerTokenMiddleware
    {
        private readonly RequestDelegate _next;

        public SwaggerTokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            string jwtToken = GetJwtToken();

            if (!string.IsNullOrEmpty(jwtToken))
            {
                httpContext.Request.Headers.Add("Authorization", $"Bearer {jwtToken}");
            }

            await _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class SwaggerTokenMiddlewareExtensions
    {
        public static IApplicationBuilder UseSwaggerTokenMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SwaggerTokenMiddleware>();
        }
    }
}
