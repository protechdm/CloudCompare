using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentSecurity;
using CloudCompare.Web.Controllers;
using System.Web.Mvc;
using CloudCompare.Web.Models;
using System.Web.Security;
using CloudCompare.Web.Helpers;
using CloudCompare.Web.FluentSecurity;

namespace CloudCompare.Web
{
    public class SecurityBootstrapper
    {
        #region Execute
        public void Execute()
        {
            SecurityConfigurator.Configure(configuration =>
            {
                configuration.ResolveServicesUsing(type =>
                {
                    var results = new List<object>();
                    if (type == typeof(IPolicyViolationHandler)) results.Add(new DefaultPolicyViolationHandler());
                    return results;
                });

                // Let Fluent Security know how to get the authentication status of the current user
                configuration.GetAuthenticationStatusFrom(() => HttpContext.Current.User.Identity.IsAuthenticated);
                //configuration.GetAuthenticationStatusFrom(() => false);
                //configuration.GetRolesFrom(Helpers.SecurityHelper.UserRoles);

                // Let Fluent Security know how to get the roles for the current user

                configuration.GetRolesFrom(() =>
                {
                    var authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];

                    if (authCookie != null)
                    {
                        var authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                        //return authTicket.UserData.Split(',');
                        var x = SecurityHelper.Test();
                        return x;
                    }
                    else
                    {
                        return new[] { "" };
                    }
                });

                // This is where you set up the policies you want Fluent Security to enforce
                //configuration.For<HomeController>().DenyAnonymousAccess();
                configuration.For<HomeController>().Ignore();
                configuration.For<AccountController>(ac => ac.LogOn()).DenyAnonymousAccess();
                //configuration.For<AccountController>(ac => ac.LogOff()).DenyAnonymousAccess();
                //configuration.For<VendorController>(ac => ac.Index()).RequireRole("Vendor");

                //configuration.For<AccountController>().DenyAuthenticatedAccess();
                //configuration.For<AccountController>(x => x.LogOff()).DenyAnonymousAccess();

                //configuration.For<HomeController>().DenyAuthenticatedAccess();
                //configuration.For<AccountController>().DenyAnonymousAccess();
                //configuration.For<AccountController>(ac => ac.LogOn()).RequireRole(UserRole.Administrator);
                //configuration.For<AccountController>(ac => ac.LogOn()).DenyAnonymousAccess();

            });

            //GlobalFilters.Filters.Add(new HandleSecurityAttribute(), 0);
        }
        #endregion
    }

    public static class StaticSecurityBootstrapper
    {

        public static ISecurityConfiguration SetupFluentSecurity()
        {

            SecurityConfigurator.Configure(configuration =>
        {
            configuration.GetAuthenticationStatusFrom(Helpers.SecurityHelper.UserIsAuthenticated);
            configuration.GetRolesFrom(Helpers.SecurityHelper.UserRoles);

            configuration.ResolveServicesUsing(type =>
            {
                var results = new List<object>();
                if (type == typeof(IPolicyViolationHandler)) results.Add(new DefaultPolicyViolationHandler());
                return results;
            });

            //configuration.Advanced.ModifySecurityContext(context => context.Data.QueryString = HttpContext.Current.Request.QueryString);
            configuration.For<HomeController>().Ignore();

            configuration.For<AccountController>(ac => ac.LogOn()).DenyAnonymousAccess();

            configuration.For<AccountController>(x => x.LogInAsAdministrator()).DenyAuthenticatedAccess();
            configuration.For<AccountController>(x => x.LogInAsPublisher()).DenyAuthenticatedAccess();
            //configuration.For<AccountController>(x => x.LogOut()).DenyAnonymousAccess();

            //configuration.For<ExampleController>(x => x.DenyAnonymousAccess()).DenyAnonymousAccess();
            //configuration.For<ExampleController>(x => x.DenyAuthenticatedAccess()).DenyAuthenticatedAccess();

            //configuration.For<ExampleController>(x => x.RequireAdministratorRole()).RequireRole(UserRole.Administrator);
            //configuration.For<ExampleController>(x => x.RequirePublisherRole()).RequireRole(UserRole.Publisher);

            //configuration.For<AdminController>().AddPolicy(new AdministratorPolicy());
            //configuration.For<AdminController>(x => x.Delete()).DelegatePolicy("LocalOnlyPolicy",
            //    context => HttpContext.Current.Request.IsLocal
            //    );

            //configuration.For<Areas.ExampleArea.Controllers.HomeController>().DenyAnonymousAccess();
            //configuration.For<Areas.ExampleArea.Controllers.HomeController>(x => x.PublishersOnly()).RequireRole(UserRole.Publisher);
            //configuration.For<Areas.ExampleArea.Controllers.HomeController>(x => x.AdministratorsOnly()).RequireRole(UserRole.Administrator);
        });
            return SecurityConfiguration.Current;
        }
    }

    public interface IBootstrapThisApp
    {
        void Execute();
    }
}