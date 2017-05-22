using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientFactory
{
    public interface IHttpClientHelper : IDisposable
    {
        Task<HttpResponseMessage> GetAsync(Uri url);
    }
}