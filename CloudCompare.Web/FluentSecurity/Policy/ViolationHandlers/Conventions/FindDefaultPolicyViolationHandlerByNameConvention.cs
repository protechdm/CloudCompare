﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity.Policy.ViolationHandlers.Conventions
{
    public class FindDefaultPolicyViolationHandlerByNameConvention : PolicyViolationHandlerFilterConvention
    {
        public override IPolicyViolationHandler GetHandlerFor(PolicyViolationException exception, IEnumerable<IPolicyViolationHandler> policyViolationHandlers)
        {
            var matchingHandler = policyViolationHandlers.SingleOrDefault(HandlerIsDefaultPolicyViolationHandler);
            return matchingHandler;
        }

        private static bool HandlerIsDefaultPolicyViolationHandler(IPolicyViolationHandler handler)
        {
            var actualHandlerName = handler.GetType().Name;
            return actualHandlerName == "DefaultPolicyViolationHandler";
        }
    }
}