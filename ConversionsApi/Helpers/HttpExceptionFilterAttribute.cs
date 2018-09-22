using Microsoft.AspNetCore.Mvc.Filters;

namespace ConversionsApi.Helpers
{
    public class HttpExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
        }
    }
}
