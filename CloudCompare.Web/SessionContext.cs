using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using CloudCompare.Web.Models;
using Castle.MicroKernel.Lifestyle.Scoped;
using Castle.MicroKernel.Context;

namespace CloudCompare.Web
{
    public static class Current
    {
        public static IUser User
        {
            get
            {
                var user = HttpContext.Current.Session["CurrentUser"] as IUser;
                return user;
            }
            set
            {
                HttpContext.Current.Session["CurrentUser"] = value;
            }
        }
    }

    public interface ICustomSession
    {
        bool JavaScriptEnabled { get; set; }
    }

    public class CustomSession : ICustomSession
    {
        public bool JavaScriptEnabled { get; set; }
    }

    public class PerWebSessionLifestyleModule : IHttpModule
    {
        private const string key = "castle.per-web-session-lifestyle-cache";

        public void Init(HttpApplication context)
        {
            var sessionState = ((SessionStateModule)context.Modules["Session"]);
            sessionState.End += SessionEnd;
        }

        private static void SessionEnd(object sender, EventArgs e)
        {
            var app = (HttpApplication)sender;

            var scope = GetScope(app.Context.Session, false);

            if (scope != null)
            {
                scope.Dispose();
            }
        }

        internal static ILifetimeScope GetScope()
        {
            var current = HttpContext.Current;

            if (current == null)
            {
                throw new InvalidOperationException("HttpContext.Current is null. PerWebSessionLifestyle can only be used in ASP.Net");
            }

            return GetScope(current.Session, true);
        }

        internal static ILifetimeScope YieldScope()
        {
            var context = HttpContext.Current;

            if (context == null)
            {
                return null;
            }

            var scope = GetScope(context.Session, true);

            if (scope != null)
            {
                context.Session.Remove(key);
            }

            return scope;
        }

        private static ILifetimeScope GetScope(HttpSessionState session, bool createIfNotPresent)
        {
            var lifetimeScope = (ILifetimeScope)session[key];

            if (lifetimeScope == null && createIfNotPresent)
            {
                lifetimeScope = new DefaultLifetimeScope(new ScopeCache(), null);
                session[key] = lifetimeScope;
                return lifetimeScope;
            }

            return lifetimeScope;
        }

        public void Dispose()
        {
        }
    }

    public class WebSessionScopeAccessor : IScopeAccessor
    {
        public void Dispose()
        {
            var scope = PerWebSessionLifestyleModule.YieldScope();
            if (scope != null)
            {
                scope.Dispose();
            }
        }

        public ILifetimeScope GetScope(CreationContext context)
        {
            return PerWebSessionLifestyleModule.GetScope();
        }
    }

}