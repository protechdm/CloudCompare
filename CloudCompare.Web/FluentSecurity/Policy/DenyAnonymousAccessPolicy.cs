﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Policy
{
    public class DenyAnonymousAccessPolicy : ISecurityPolicy
    {
        public PolicyResult Enforce(ISecurityContext context)
        {
            if (context.CurrenUserAuthenticated() == false)
            {
                return PolicyResult.CreateFailureResult(this, "Anonymous access denied");
            }
            return PolicyResult.CreateSuccessResult(this);
        }
    }
}