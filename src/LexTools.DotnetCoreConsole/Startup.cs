using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

namespace LexTools.DotnetCoreConsole
{
    public class Startup
    {
        private readonly IDiConfigurator _diConfigurator;

        public IConfigurationRoot Configuration { get; }

        private readonly Logger _serilogLogger;

        public Startup(IDiConfigurator diConfigurator)
        {
            _diConfigurator = diConfigurator;
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{environment}.json", true);

            Configuration = builder.Build();

            _serilogLogger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .CreateLogger();
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddSingleton(_serilogLogger);
            services.AddSingleton(services);

            _diConfigurator.Init(Configuration);
            var provider = _diConfigurator.Configure(services);

            return provider;
        }

        public void Configure(ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            loggerFactory.AddSerilog(_serilogLogger);
        }
    }
}
