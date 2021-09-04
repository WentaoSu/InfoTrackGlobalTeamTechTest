using BusinessLogic.Exceptions;
using InfoTrackGlobalTeamTechTest.Responses;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace InfoTrackGlobalTeamTechTest.Middleware
{
    /// <summary>
    /// ErrorHandlingMiddleWare
    /// </summary>
    public class ErrorHandlingMiddleWare
    {
        private readonly RequestDelegate _next;
        /// <summary>
        /// ErrorHandlingMiddleWare constructor
        /// </summary>
        /// <param name="next"></param>
        public ErrorHandlingMiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var model = ErrorResponse<string>.Create(error.Message);
                if (error is BusinessLogicExceptionBase)
                {
                    if (error is TimeslotBookedOutException)
                        response.StatusCode = (int)HttpStatusCode.Conflict;
                    else
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                }
                else
                {
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                }
                var result = JsonSerializer.Serialize(model);
                await response.WriteAsync(result);
            }
        }
    }
}
