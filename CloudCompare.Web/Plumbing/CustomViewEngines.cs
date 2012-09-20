using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CloudCompare.Web.Plumbing
{
    public class CustomViewEngines
    {
    }

    public class NoScriptRazorViewEngine : RazorViewEngine
    {
        private static string[] NoScriptPartialFormats = new[] {
            //"~/Views/{1}/Shared/NoScript/{1}/{0}.cshtml",
            "~/Views/Shared/NoScript/{0}.cshtml"
        };

        public NoScriptRazorViewEngine()
            //: base()
        {
            base.PartialViewLocationFormats = base.ViewLocationFormats.Union(NoScriptPartialFormats).ToArray();

        //    base.PartialViewLocationFormats = base.PartialViewLocationFormats.Concat(new[] {
        //    "~/Views/Payments/{1}/{0}.cshtml",
        //    "~/Views/Payments/{1}/{0}.vbhtml"
        //}).ToArray();
        }
    }

}