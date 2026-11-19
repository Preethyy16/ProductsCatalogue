using System.Diagnostics;

namespace ProductsCatalogue.Middleware
{
    public class RequestLoggignMiddleware
    {
        private readonly ILogger _logger;
        private readonly RequestDelegate _next;

        public RequestLoggignMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var sw = Stopwatch.StartNew();
            try
            {
                await _next(context);
            }
            finally
            {
                sw.Stop();
                _logger.LogInformation("Request received with http method {Method} with statusCode {code} in {timetaken} ms", context.Request.Method, context.Response.StatusCode, sw.ElapsedMilliseconds);
            }

        }
    }
}
