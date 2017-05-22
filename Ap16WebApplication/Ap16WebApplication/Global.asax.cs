using System.Web.Mvc;
using System.Web.Routing;
using Ap16WebApplication.DependencyInjection;

namespace Ap16WebApplication
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            DependencyResolverFactory.Initialise();
            //Register our custom controller factory
            ControllerBuilder.Current.SetControllerFactory(typeof(ControllerFactory));

        }
    }
}
