using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using CloudCompare.Web.FluentSecurity;
using CloudCompare.Web.Controllers;
using Castle.Windsor;
using Castle.Windsor.Installer;
using CloudCompare.Web.Plumbing;

namespace CloudCompare.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static IWindsorContainer container { get; private set; }

        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new HandleSecurityAttribute(), 0);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

            routes.MapRoute(
                "JavascriptControl", // Route name
                "{controller}/{action}/{javascriptenabled}", // URL with parameters
                new { controller = "Home", action = "IndexCustom", id = UrlParameter.Optional, javascriptenabled = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "TabResultsControl", // Route name
                "{controller}/{action}/{tab}", // URL with parameters
                new { controller = "Home", action = "HomePage", tab = UrlParameter.Optional } // Parameter defaults
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            new SecurityBootstrapper().Execute();
            //StaticSecurityBootstrapper.SetupFluentSecurity();
            container = new WindsorContainer().Install(FromAssembly.This());
            var controllerFactory = new WindsorControllerFactory(container.Kernel);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);

            //SecurityConfigurator.Configure(configuration =>
            //    {
            //        configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
            //        configuration.For<HomeController>().DenyAnonymousAccess();
            //        configuration.For<AccountController>(ac => ac.LogOn()).Ignore();
            //    });
            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ViewEngines.Engines.Add(new NoScriptRazorViewEngine());

            
        }

        protected void Application_End()
        {
            container.Dispose();
        }
    }
}