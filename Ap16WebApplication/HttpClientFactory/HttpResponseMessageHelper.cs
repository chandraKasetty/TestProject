using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientFactory
{
    public class HttpResponseMessageHelper : IHttpResponseMessageHelper
    {
        public async Task<HttpJsonResponseMessage> GetJsonMessageAsync<T>(HttpResponseMessage httpResponseMessage)
        {
            var result = await httpResponseMessage.Content.ReadAsStringAsync();

            dynamic stuff = JsonConvert.DeserializeObject<T>(result);

            return new HttpJsonResponseMessage
            {
                HttpResponseMessage = httpResponseMessage,
                Result = result,
                JsonResult = stuff
            };

        }

    }
}
