using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Rewrite;

namespace LexTools.AspNetCore.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpsRedirect(this IApplicationBuilder builder)
        {
            var options = new RewriteOptions()
                .AddRedirectToHttps();
            builder.UseRewriter(options);

            return builder;
        }
    }
}