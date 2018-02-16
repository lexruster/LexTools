using System.Threading.Tasks;

namespace LexTools.Api
{
    public interface IApiClient
    {
        Task<TResponse> Get<TResponse>(string requestUrl) where TResponse : new();
        Task<TResponse> Post<TResponse, TRequest>(string requestUrl, TRequest request) where TResponse : new();
        Task<TResponse> Put<TResponse, TRequest>(string requestUrl, TRequest request) where TResponse : new();
        Task<TResponse> Delete<TResponse>(string requestUrl) where TResponse : new();
        Task<TResponse> Delete<TResponse, TRequest>(string requestUrl, TRequest request) where TResponse : new();

        Task<string> GetString(string requestUrl);
    }
}