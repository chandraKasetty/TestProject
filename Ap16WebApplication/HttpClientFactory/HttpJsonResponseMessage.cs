using System;
using System.Net.Http;

namespace HttpClientFactory
{
    public class HttpJsonResponseMessage
    {
        public HttpResponseMessage HttpResponseMessage;
        public string Result;
        public Object JsonResult;
    }
}