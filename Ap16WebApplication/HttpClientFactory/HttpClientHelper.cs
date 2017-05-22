using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace HttpClientFactory
{
    public class HttpClientHelper : HttpClient, IHttpClientHelper
    {
        public HttpClientHelper()
        {
            Timeout = TimeSpan.FromSeconds(30);
            DefaultRequestHeaders.Add("User-Agent", "Other");
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        
        public new Task<HttpResponseMessage> GetAsync(Uri url)
        {
            return base.GetAsync(url);
        }
    }
}
