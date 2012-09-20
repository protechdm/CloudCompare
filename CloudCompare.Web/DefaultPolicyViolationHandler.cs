using System.Web.Mvc;
using FluentSecurity;
using CloudCompare.Web.FluentSecurity;

namespace CloudCompare.Web
{
    public class DefaultPolicyViolationHandler : IPolicyViolationHandler
    {
        public string ViewName = "AccessDenied";

        public ActionResult Handle(PolicyViolationException exception)
        {
            return new ViewResult { ViewName = ViewName };
        }
    }
}
