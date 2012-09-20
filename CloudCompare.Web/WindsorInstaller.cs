using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using FluentSecurity;
using System.Linq.Expressions;
using System.Web.Mvc;
using CloudCompare.Web.FluentSecurity;

namespace CloudCompare.Web
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(AllTypes.FromThisAssembly()
                .BasedOn(typeof(IPolicyViolationHandler))
                .Configure(h => h.LifestyleSingleton())
                );
        }

    }
}