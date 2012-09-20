using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudCompare.Web.FluentSecurity.Policy.ViolationHandlers.Conventions;
using CloudCompare.Web.FluentSecurity.Caching;

namespace CloudCompare.Web.FluentSecurity.Configuration
{
    public class AdvancedConfiguration : IAdvancedConfiguration
    {
        internal AdvancedConfiguration()
        {
            Conventions = new Conventions
			{
				new FindByPolicyNameConvention(),
				new FindDefaultPolicyViolationHandlerByNameConvention()
			};

            SetDefaultResultsCacheLifecycle(Cache.DoNotCache);
        }

        public Conventions Conventions { get; private set; }
        public Cache DefaultResultsCacheLifecycle { get; private set; }
        public Action<ISecurityContext> SecurityContextModifyer { get; private set; }

        public void SetDefaultResultsCacheLifecycle(Cache lifecycle)
        {
            DefaultResultsCacheLifecycle = lifecycle;
        }

        public void ModifySecurityContext(Action<ISecurityContext> modifyer)
        {
            SecurityContextModifyer = modifyer;
        }

        public void Violations(Action<ViolationConfigurationExpression> violationConfigurationExpression)
        {
            if (violationConfigurationExpression == null) throw new ArgumentNullException("violationConfigurationExpression");
            violationConfigurationExpression.Invoke(new ViolationConfigurationExpression(Conventions));
        }
    }
}