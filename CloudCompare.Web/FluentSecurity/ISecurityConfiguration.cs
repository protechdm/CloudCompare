using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CloudCompare.Web.FluentSecurity.Configuration;

namespace CloudCompare.Web.FluentSecurity
{
    public interface ISecurityConfiguration
    {
        IAdvancedConfiguration Advanced { get; }
        IEnumerable<IPolicyContainer> PolicyContainers { get; }
        ISecurityServiceLocator ExternalServiceLocator { get; }
        bool IgnoreMissingConfiguration { get; }
        string WhatDoIHave();
    }
}