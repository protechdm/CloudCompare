﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal class TransientLifecycle : ILifecycle
    {
        public IObjectCache FindCache()
        {
            return new NullObjectCache();
        }
    }
}