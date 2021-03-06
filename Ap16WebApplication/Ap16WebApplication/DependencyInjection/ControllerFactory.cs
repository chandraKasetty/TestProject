﻿using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.Unity;

namespace Ap16WebApplication.DependencyInjection
{

    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            try
            {
                if (controllerType == null)
                    throw new ArgumentNullException(nameof(controllerType));

                if (!typeof(IController).IsAssignableFrom(controllerType))
                    throw new ArgumentException($"Type requested is not a controller: {controllerType.Name}",
                        nameof(controllerType));

                return MvcUnityContainer.Container.Resolve(controllerType) as IController;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }

    public static class MvcUnityContainer
    {
        public static UnityContainer Container { get; set; }
    }
}