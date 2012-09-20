using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.ServiceLocation.Lifecycles
{
    internal interface ILifecycle
    {
        IObjectCache FindCache();
    }
}