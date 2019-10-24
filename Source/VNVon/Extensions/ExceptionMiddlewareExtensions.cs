using log4net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.Net;
using VNVon.Service.CustomException;

namespace VNVon.Extensions
{
    public class ExceptionMiddlewareExtensions : IExceptionFilter
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ExceptionMiddlewareExtensions));

        public void OnException(ExceptionContext actionExecutedContext)
        {
            // Custom Exceptions
            if (actionExecutedContext.Exception is ServiceException)
            {
                var customEx = actionExecutedContext.Exception as ServiceException;
                var content = JsonConvert.SerializeObject(customEx.GetObjectMessage());

                actionExecutedContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                actionExecutedContext.HttpContext.Response.ContentType = "application/json";
                actionExecutedContext.HttpContext.Response.ContentLength = content.Length;
                actionExecutedContext.HttpContext.Response.WriteAsync(content);
            }
            else
            {
                // Unhandled exceptions
                string exceptionMessage = string.Empty;
                if (actionExecutedContext.Exception.InnerException == null)
                {
                    exceptionMessage = actionExecutedContext.Exception.Message;
                }
                else
                {
                    exceptionMessage = actionExecutedContext.Exception.InnerException.Message;
                }

                // TODO: Log exception message to database or local
                log.Error(exceptionMessage, actionExecutedContext.Exception);
                
                var content = JsonConvert.SerializeObject(new { ErrorCode = 500, Message = "An error has occured." });

                actionExecutedContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                actionExecutedContext.HttpContext.Response.ContentType = "application/json";
                actionExecutedContext.HttpContext.Response.ContentLength = content.Length;
                actionExecutedContext.HttpContext.Response.WriteAsync(content);
            }            
        }
    }
}
