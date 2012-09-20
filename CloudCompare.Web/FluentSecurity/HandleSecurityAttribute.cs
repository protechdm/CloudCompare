﻿using System;
using System.Web.Mvc;
using CloudCompare.Web.FluentSecurity.ServiceLocation;

namespace CloudCompare.Web.FluentSecurity
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HandleSecurityAttribute : ActionFilterAttribute
    {
        internal ISecurityHandler Handler { get; private set; }

        public HandleSecurityAttribute() : this(ServiceLocator.Current.Resolve<ISecurityHandler>()) { }

        public HandleSecurityAttribute(ISecurityHandler securityHandler)
        {
            Handler = securityHandler;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionName = filterContext.ActionDescriptor.ActionName;
            var controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerType.FullName;

            var securityContext = SecurityContext.Current;
            securityContext.Data.RouteValues = filterContext.RouteData.Values;

            var overrideResult = Handler.HandleSecurityFor(controllerName, actionName, securityContext);
            if (overrideResult != null) filterContext.Result = overrideResult;
        }
    }
}