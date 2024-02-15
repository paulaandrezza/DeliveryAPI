using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DeliveryAPI.Filters
{
    public class ExceptionFilter : IAsyncExceptionFilter
    {
        public async Task OnExceptionAsync(ExceptionContext context)
        {
            var objectResponse = new
            {
                ErrorMessage = "An unexpected error occurred, please wait and try again later"
            };

            context.Result = new ObjectResult(objectResponse)
            {
                StatusCode = 500
            };

            await Task.CompletedTask;
        }
    }
}
