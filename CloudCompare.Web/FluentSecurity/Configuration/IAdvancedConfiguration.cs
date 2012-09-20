using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudCompare.Web.FluentSecurity.Caching;

namespace CloudCompare.Web.FluentSecurity.Configuration
{
    public interface IAdvancedConfiguration
    {
        Conventions Conventions { get; }
        Cache DefaultResultsCacheLifecycle { get; }
        Action<ISecurityContext> SecurityContextModifyer { get; }
    }
}