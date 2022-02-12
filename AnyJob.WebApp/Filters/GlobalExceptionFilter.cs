using AnyJob.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace AnyJob.WebApp.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        private class ErrorResponse
        {
            public string Message { get; set; }

            public int StatusCode { get; init; }
        }

        public void OnException(ExceptionContext context)
        {
            Exception exception = context.Exception;
            string errorMessage = "Occured an internal server error";
            int statusCode = 500; // by default internal server error code

            if (exception is BusinessException) // Exception of business-logic (validation)
            {
                errorMessage = exception.Message;
                statusCode = 400;
            }

            ErrorResponse response = new()
            {
                Message = errorMessage,
                StatusCode = statusCode
            };
            context.Result = new ObjectResult(response)
            {
                StatusCode = response.StatusCode,
                DeclaredType = typeof(ErrorResponse),
                ContentTypes = new MediaTypeCollection { "application/json" }
            };
        }
    }
}