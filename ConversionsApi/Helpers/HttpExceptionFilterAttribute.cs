using Microsoft.AspNetCore.Mvc.Filters;

namespace Chimerical.Conversions.Api.Helpers
{
    public class HttpExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
        }
    }
}
