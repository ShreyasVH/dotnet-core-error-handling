using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using DotnetCoreMssql.Exceptions;
using DotnetCoreMssql.Responses;

namespace DotnetCoreMssql.Exceptions
{
    public class CustomExceptionHandler : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is MyException exception)
            {
                Console.WriteLine(exception.Description);
                var response = new Response(exception.Description);
                context.Result = new ObjectResult(response)
                {
                    StatusCode = exception.HttpStatusCode
                };
                context.ExceptionHandled = true;
            }
        }
    }
}