using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.Models
{
    public class User : IUser
    {
        public User()
        {
            Roles = new List<UserRole>();
        }

        public IEnumerable<UserRole> Roles { get; set; }
    }
}