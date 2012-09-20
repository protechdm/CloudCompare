﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using FluentSecurity;
using CloudCompare.Web;
using CloudCompare.Web.Models;
using CloudCompare.Web.FluentSecurity;
namespace CloudCompare.Web.Helpers
{
    public static class SecurityHelper
    {
        public static bool ActionIsAllowedForUser(string controllerName, string actionName)
        {
            var configuration = SecurityConfiguration.Current;
            var policyContainer = configuration.PolicyContainers.GetContainerFor(controllerName, actionName);
            if (policyContainer != null)
            {
                var context = SecurityContext.Current;
                var results = policyContainer.EnforcePolicies(context);
                return results.All(x => x.ViolationOccured == false);
            }
            return true;
        }

        public static bool UserIsAuthenticated()
        {
            var currentUser = Current.User;
            return currentUser != null;
        }

        public static object[] UserRoles()
        {
            var currentUser = Current.User;
            if (currentUser != null)
            {
                //return currentUser.Roles.ToObjectArray();
                return Test();
            }
            return null;
        }

        //public static object[] ToObjectArray(this IEnumerable<UserRole> collection)
        //{
        //    var objectArray = new object[collection.Count()];
        //    var index = 0;
        //    foreach (var o in collection)
        //    {
        //        objectArray[index] = o;
        //        index++;
        //    }
        //    return objectArray;
        //}

        public static string[] Test()
        {
            var rolesArray = new string[System.Web.Security.Roles.GetRolesForUser().Count()];
            var index = 0;
            foreach (var o in System.Web.Security.Roles.GetRolesForUser())
            {
                rolesArray[index] = o;
                index++;
            }
            return rolesArray;

        }
    }
}