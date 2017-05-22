using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ap16WebApplication.URIHelper;
using DTO;
using HttpClientFactory;

namespace Ap16WebApplication.ServiceAPI
{
    public class RestServiceApi : IRestServiceApi
    {

        private readonly IHttpClientHelper _httpClientFactory;

        private readonly IUri _urlHelper;

        private readonly IHttpResponseMessageHelper _httpResponseMessageHelper;

        public RestServiceApi(IHttpClientHelper httpClientFactory, IUri uriHelper, IHttpResponseMessageHelper httpResponseMessage)
        {
            _httpClientFactory = httpClientFactory;
            _urlHelper = uriHelper;
            _httpResponseMessageHelper = httpResponseMessage;
        }

        public async Task<List<TaskDetailsDTO>> GetTaskDetailsAsync()
        {
            HttpJsonResponseMessage jsonResponse;

            using (var client = _httpClientFactory)
            {
                var response = await client.GetAsync(_urlHelper.GetTaskDetailsUri());

                if (!response.IsSuccessStatusCode) throw new Exception("Error getting TaskDetails");
                jsonResponse = await _httpResponseMessageHelper.GetJsonMessageAsync<List<TaskDetailsDTO>>(response);
                return (List<TaskDetailsDTO>)jsonResponse.JsonResult;
            }
        }
        }

        
    }

