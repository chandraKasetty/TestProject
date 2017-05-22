using System;

namespace Ap16WebApplication.URIHelper
{
    public class WebApiUri: IUri
    {
        public Uri GetTaskDetailsUri()
        {

            return new Uri("http://localhost:56956/api/Task/GetTaskDetails");
        }
 
    }
}