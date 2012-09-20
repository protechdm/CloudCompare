using System.Web.Mvc;

namespace CloudCompare.Web.FluentSecurity
{
    public interface ISecurityHandler
    {
        ActionResult HandleSecurityFor(string controllerName, string actionName, ISecurityContext securityContext);
    }
}