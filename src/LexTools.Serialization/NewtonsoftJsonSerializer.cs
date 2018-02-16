using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LexTools.Serialization
{
    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerSettings _serializeSettings;
        private readonly JsonSerializerSettings _deserializeSettings;


        public NewtonsoftJsonSerializer()
        {
            _serializeSettings = new JsonSerializerSettings();
            _serializeSettings.Converters.Add(new StringEnumConverter());
            _serializeSettings.Converters.Add(new IsoDateTimeConverter());

            _deserializeSettings=new JsonSerializerSettings();
        }

        public NewtonsoftJsonSerializer(params JsonConverter[] converters):this()
        {
            converters.ToList().ForEach(c =>
            {
                _serializeSettings.Converters.Add(c);
                _deserializeSettings.Converters.Add(c);
            });
            
        }

        public string Serialize<T>(T value, bool formatted = false)
        {
            Formatting formatting = formatted ? Formatting.Indented : Formatting.None;
            return JsonConvert.SerializeObject(value, formatting, _serializeSettings);
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, _deserializeSettings);
        }
    }
}
