
using System.Runtime.CompilerServices;

namespace HomeWork16.Services
{
    public class ExeptionMiddleWare
    {
        private readonly RequestDelegate _next;
        public ExeptionMiddleWare(RequestDelegate next)
        {
                _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
           
                if(context == null)
                 throw new ArgumentNullException(nameof(context));

               await _next.Invoke(context);
            
        }
    }
}
