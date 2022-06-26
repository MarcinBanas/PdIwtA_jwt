using Microsoft.AspNetCore.Http;
using Lab.Exceptions;
using System.Threading.Tasks;

namespace Lab.Middlwares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next; 

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) 
        {
            try
            {
                await _next(context);
            }
            catch (ProductsAlreadyExistsException e)
            {
                context.Response.StatusCode = StatusCodes.Status402PaymentRequired;
            }
            catch (System.Exception)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
        }
    }
}
