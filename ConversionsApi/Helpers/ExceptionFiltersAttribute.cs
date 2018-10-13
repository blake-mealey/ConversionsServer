using Chimerical.Conversions.ClientModels.Models;
using Chimerical.Conversions.Dal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace Chimerical.Conversions.Api.Helpers
{
    public class ExceptionFiltersAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            var statusCode = HttpStatusCode.InternalServerError;
            switch (exception)
            {
                case DataNotFoundException _:
                    statusCode = HttpStatusCode.NotFound;
                    break;
                case ArgumentException _:
                case FormatException _:
                    statusCode = HttpStatusCode.BadRequest;
                    break;
            }

            Console.WriteLine(exception.StackTrace);

            context.Result = new JsonResult(new ErrorClientModel
            {
                Message = exception.GetBaseException().Message
            })
            { StatusCode = (int)statusCode };
        }
    }
}
