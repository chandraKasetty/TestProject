using Microsoft.Practices.Unity;
using System.Web.Http;
using BLL;
using DAL;
using Unity.WebApi;

namespace WebApi
{
    public static class UnityConfig
    {
        /// <summary>
        /// Registering Dependencies using Unity.webapi
        /// </summary>
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            container
                .RegisterType<ITaskBLL, TaskBLL>()
                .RegisterType<ITaskDAL, TaskDAL>()
                .RegisterType<IAssigneesDAL, AssigneesDAL>()
                .RegisterType<IAttachmentsDAL, AttachmentsDAL>();


        }
    }
}