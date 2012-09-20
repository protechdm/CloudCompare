using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Caching
{
    public interface ICacheKeyProvider
    {
        string Get(ISecurityContext securityContext);
    }
}