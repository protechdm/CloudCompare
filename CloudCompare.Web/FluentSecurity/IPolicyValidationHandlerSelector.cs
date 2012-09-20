using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity
{
    public interface IPolicyViolationHandlerSelector
    {
        IPolicyViolationHandler FindHandlerFor(PolicyViolationException exception);
    }
}