﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public interface IPolicyViolationHandlerConvention : IConvention
    {
        IPolicyViolationHandler GetHandlerFor(PolicyViolationException exception);
    }
}