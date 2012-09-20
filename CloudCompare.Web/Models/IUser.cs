using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.Models
{
    public interface IUser
    {
        IEnumerable<UserRole> Roles { get; set; }
    }
}