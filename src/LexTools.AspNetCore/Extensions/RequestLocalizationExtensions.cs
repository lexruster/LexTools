using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

namespace LexTools.AspNetCore.Extensions
{
    public static class RequestLocalizationExtensions
    {
        public static IApplicationBuilder UseDefaultRequestLocalization(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(new CultureInfo("en-US")),
                SupportedCultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US")
                },
                SupportedUICultures = new List<CultureInfo>
                {
                    new CultureInfo("en-US")
                }
            });
        }
    }
}