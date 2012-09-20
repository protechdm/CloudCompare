using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudCompare.Web.Helpers
{
    public static class StringExtensions
    {
        public static string AddImagePath(this string imageName)
        {
            string imagesPath = System.Configuration.ConfigurationManager.AppSettings["LogosFolder"].ToString();
            return imagesPath + imageName;
        }

    }
}