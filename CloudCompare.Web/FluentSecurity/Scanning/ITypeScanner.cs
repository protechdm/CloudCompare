using System;
using System.Collections.Generic;
using System.Reflection;

namespace CloudCompare.Web.FluentSecurity.Scanning
{
    internal interface ITypeScanner
    {
        IEnumerable<Type> Scan(IEnumerable<Assembly> assemblies);
    }
}