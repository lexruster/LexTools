using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace LexTools.AspNetCore.Extensions
{
    public static class MvcJsonOptionsExtensions
    {
        public static IMvcBuilder AddDefaultJsonOptions(this IMvcBuilder builder)
        {
            return builder.AddJsonOptions(json =>
            {
                json.SerializerSettings.Converters.Add(new StringEnumConverter());
                json.SerializerSettings.Converters.Add(new IsoDateTimeConverter());
                json.SerializerSettings.ContractResolver = new DefaultContractResolver();
            });
        }
    }
}