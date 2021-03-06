﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class DefaultPolicyViolationHandlerIsOfTypeConvention<TPolicyViolationHandler> : LazyTypePolicyViolationHandlerConvention<TPolicyViolationHandler> where TPolicyViolationHandler : class, IPolicyViolationHandler { }
}