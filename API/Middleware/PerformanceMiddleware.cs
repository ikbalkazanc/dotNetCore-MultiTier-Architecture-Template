using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace API.Middleware
{
    public class PerformanceMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<PerformanceMiddleware> _logger;

        public PerformanceMiddleware(RequestDelegate next, ILogger<PerformanceMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            const int performanceTimeLog = 500;

            Stopwatch sw = new Stopwatch();

            sw.Start();

            await _next(context);

            sw.Stop();

            if (performanceTimeLog < sw.ElapsedMilliseconds)
                _logger.LogWarning("Request {method} {path} it took about {elapsed} ms",
                    context.Request?.Method,
                    context.Request?.Path.Value,
                    sw.ElapsedMilliseconds);
        }
    }
}
