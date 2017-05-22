using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactory
{
    public interface IHttpResponseMessageHelper
    {
        Task<HttpJsonResponseMessage> GetJsonMessageAsync<T>(HttpResponseMessage httpResponseMessage);
    }
}