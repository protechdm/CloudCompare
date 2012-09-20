using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.FluentSecurity
{
    public interface ISecurityContext
    {
        dynamic Data { get; }
        bool CurrenUserAuthenticated();
        IEnumerable<object> CurrenUserRoles();
    }
}