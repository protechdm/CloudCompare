using System.Web.Mvc;

namespace CloudCompare.Web.FluentSecurity
{
    public class ExceptionPolicyViolationHandler : IPolicyViolationHandler
    {
        public ActionResult Handle(PolicyViolationException exception)
        {
            throw exception;
        }
    }
}