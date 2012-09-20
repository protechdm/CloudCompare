using System.Web.Mvc;

namespace CloudCompare.Web.FluentSecurity
{
    public interface IPolicyViolationHandler
    {
        ActionResult Handle(PolicyViolationException exception);
    }
}