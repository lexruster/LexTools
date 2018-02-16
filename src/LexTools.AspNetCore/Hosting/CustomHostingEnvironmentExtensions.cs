using System;
using Microsoft.AspNetCore.Hosting;

namespace LexTools.AspNetCore.Hosting
{
    public static class CustomHostingEnvironmentExtensions
    {
        /// <summary>
        /// Is Enviroment is Staging or Production
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        /// <returns></returns>
        public static bool IsLive(this IHostingEnvironment hostingEnvironment)
        {
            if (hostingEnvironment == null)
                throw new ArgumentNullException(nameof(hostingEnvironment));
            return hostingEnvironment.IsEnvironment(EnvironmentName.Production) || hostingEnvironment.IsEnvironment(EnvironmentName.Staging);
        }
    }
}