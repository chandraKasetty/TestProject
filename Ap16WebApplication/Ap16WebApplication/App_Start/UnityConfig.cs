using System.Web.Mvc;
using Ap16WebApplication.ServiceAPI;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using HttpClientFactory;
using Ap16WebApplication.URIHelper;

namespace Ap16WebApplication
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IRestServiceApi, RestServiceApi>();
            container.RegisterType<IHttpClientHelper, HttpClientHelper>();
            container.RegisterType<IUri, WebApiUri>();
            container.RegisterType<IHttpResponseMessageHelper, HttpResponseMessageHelper>();
            
           
        }
    }
}