using System.Web.Mvc;
using Ap16WebApplication.ServiceAPI;
using Ap16WebApplication.URIHelper;
using HttpClientFactory;
using Microsoft.Practices.Unity;
using Unity.Mvc5;

namespace Ap16WebApplication.DependencyInjection
{
    public class DependencyResolverFactory
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IHttpClientHelper, HttpClientHelper>();
            container.RegisterType<IHttpResponseMessageHelper, HttpResponseMessageHelper>();
            container.RegisterType<IUri, WebApiUri>();
            container.RegisterType<IRestServiceApi, RestServiceApi>();
            MvcUnityContainer.Container = container;
            return container;
        }
    }
}