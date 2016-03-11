using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using HMS.Infrastructure;
using HMS.Infrastructure.Interfaces;
using System.Web.Mvc;

namespace HMS.App_Start
{
    public static class IocConfig
    {
        public static void ConfigUnityContainer()
        {
            IUnityContainer container = new UnityContainer();
            registerServices(container);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
             
        }

        private static void registerServices(IUnityContainer container)
        {
            container.RegisterType<ILoginProvider, Login>();
        }
    }
}