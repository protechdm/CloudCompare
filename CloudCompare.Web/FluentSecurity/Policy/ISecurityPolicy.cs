using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Policy
{
    public interface ISecurityPolicy
    {
        PolicyResult Enforce(ISecurityContext context);
    }
}