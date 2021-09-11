using System;
using System.Net;
using System.Threading.Tasks;
using EAP.Contracts.IRepositoty.LoggerManager;
using EAP.Shared.Dtos.ErrorHandle;
using Microsoft.AspNetCore.Http;

namespace EAP.API.CcustomExceptionMiddleware
{
    public class ExpectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;
        public ExpectionMiddleware(RequestDelegate next,
            ILoggerManager logger)
        {
            this._next = next;
            this._logger = logger;
        }
        public async Task InvokeAsync(HttpContext http)
        {
            try
            {
                await _next(http);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong {ex.Message}");
                await HandleExceptionAsync(http);
            }
        }

        private Task HandleExceptionAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            return context.Response.WriteAsync(new ErrorDetails
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error from custom middleware"
            }.ToString());
        }
    }
}