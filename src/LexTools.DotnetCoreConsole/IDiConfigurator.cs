using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LexTools.DotnetCoreConsole
{
    public interface IDiConfigurator
    {
        IServiceProvider Configure(IServiceCollection services);

        void Init(IConfiguration configuration);
    }
}