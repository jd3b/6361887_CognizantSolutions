using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace _3_EmployeeApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        private readonly string _logFilePath;

        public CustomExceptionFilter()
        {
            _logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "error.log");
        }

        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            var logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error: {exception.Message}\n" +
                           $"Stack Trace: {exception.StackTrace}\n" +
                           $"Request Path: {context.HttpContext.Request.Path}\n\n";

            File.AppendAllText(_logFilePath, logMessage);

            context.Result = new ObjectResult(new
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Message = "An error occurred while processing your request.",
                Detailed = exception.Message
            })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };

            context.ExceptionHandled = true;
        }
    }
}