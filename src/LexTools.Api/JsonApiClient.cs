using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LexTools.Serialization;

namespace LexTools.Api
{
    public class JsonApiClient : IApiClient
    {
        private readonly Uri _baseAddress;
        private readonly IJsonSerializer _serializer = new NewtonsoftJsonSerializer();
        private readonly string _applicationJson = "application/json";

        public JsonApiClient()
        {
        }

        public JsonApiClient(Uri baseAddress)
        {
            _baseAddress = baseAddress;
        }

        public JsonApiClient(Uri baseAddress, IJsonSerializer jsonSerializer):this(baseAddress)
        {
            _serializer = jsonSerializer;
        }

        public async Task<TResponse> Get<TResponse>(string requestUrl) where TResponse : new()
        {
            var responseObject = await Wrap<TResponse>(async () =>
            {
                using (var client = CreateAsync(_baseAddress))
                {
                    return await client.GetAsync(requestUrl);
                }
            });

            return responseObject;
        }

        public async Task<TResponse> Post<TResponse, TRequest>(string requestUrl, TRequest request)
            where TResponse : new()
        {
            var responseObject = await Wrap<TResponse>(async () =>
            {
                using (var client = CreateAsync(_baseAddress))
                {
                    var httpRequest = new HttpRequestMessage
                    {
                        Content = new StringContent(_serializer.Serialize(request), Encoding.UTF8, _applicationJson),
                        Method = HttpMethod.Post,
                        RequestUri = GetRequestUri(requestUrl)
                    };

                    return await client.SendAsync(httpRequest);
                }
            });

            return responseObject;
        }

        public async Task<TResponse> Put<TResponse, TRequest>(string requestUrl, TRequest request)
            where TResponse : new()
        {
            var responseObject = await Wrap<TResponse>(async () =>
            {
                using (var client = CreateAsync(_baseAddress))
                {
                    var httpRequest = new HttpRequestMessage
                    {
                        Content = new StringContent(_serializer.Serialize(request), Encoding.UTF8, _applicationJson),
                        Method = HttpMethod.Put,
                        RequestUri = GetRequestUri(requestUrl)
                    };

                    return await client.SendAsync(httpRequest);
                }
            });

            return responseObject;
        }

        public async Task<TResponse> Delete<TResponse, TRequest>(string requestUrl, TRequest request) where TResponse : new()
        {
            var responseObject = await Wrap<TResponse>(async () =>
            {
                using (var client = CreateAsync(_baseAddress))
                {
                    var httpRequest = new HttpRequestMessage
                    {
                        Content = new StringContent(_serializer.Serialize(request), Encoding.UTF8, _applicationJson),
                        Method = HttpMethod.Delete,
                        RequestUri = GetRequestUri(requestUrl)
                    };

                    return await client.SendAsync(httpRequest);
                }
            });

            return responseObject;
        }

        private Uri GetRequestUri(string requestUrl)
        {
            if (_baseAddress != null)
            {
                return new Uri(requestUrl, UriKind.Relative);
            }

            return new Uri(requestUrl, UriKind.Absolute);
        }

        public async Task<TResponse> Delete<TResponse>(string requestUrl) where TResponse : new()
        {
            var responseObject = await Wrap<TResponse>(async () =>
            {
                using (var client = CreateAsync(_baseAddress))
                {
                    return await client.DeleteAsync(requestUrl);
                }
            });

            return responseObject;
        }

        public async Task<string> GetString(string requestUrl)
        {
            using (var client = CreateAsync(_baseAddress))
            {
                return await client.GetStringAsync(requestUrl);
            }
        }

        public async Task<TResponse> Wrap<TResponse>(Func<Task<HttpResponseMessage>> func) where TResponse : new()
        {
            var httpResponseMessage = await func();

            var responseObject = await ReadResponse<TResponse>(httpResponseMessage);
            return responseObject;
        }

        private async Task<TResponse> ReadResponse<TResponse>(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();
            var str = await response.Content.ReadAsStringAsync();
            var responseObject = _serializer.Deserialize<TResponse>(str);

            return responseObject;
        }

        public virtual HttpClient CreateAsync(Uri baseAddress)
        {
            var client = new HttpClient
            {
                BaseAddress = baseAddress
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(_applicationJson));

            return client;
        }
    }
}