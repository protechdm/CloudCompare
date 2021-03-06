﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudCompare.Web.FluentSecurity.ServiceLocation.Lifecycles;

namespace CloudCompare.Web.FluentSecurity.ServiceLocation
{
    public enum Lifecycle
    {
        Transient,
        Singleton,
        HybridHttpContext,
        HybridHttpSession
    }

    internal static class Lifecycle<TLifecycle> where TLifecycle : ILifecycle, new()
    {
        static Lifecycle()
        {
            Instance = new TLifecycle();
        }

        public static ILifecycle Instance { get; private set; }
    }
}