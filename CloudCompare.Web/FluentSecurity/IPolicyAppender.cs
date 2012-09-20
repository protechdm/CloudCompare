using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudCompare.Web.FluentSecurity.Policy;

namespace CloudCompare.Web.FluentSecurity
{
    public interface IPolicyAppender
    {
        void UpdatePolicies(ISecurityPolicy securityPolicyToAdd, IList<ISecurityPolicy> policies);
    }
}