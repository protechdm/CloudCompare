using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Castle.Facilities.Logging;

namespace CloudCompare.Web.Installers
{
    public class LoggerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            //container.Register(Classes.FromThisAssembly()
            //                    .BasedOn<IController>()
            //                    .LifestyleTransient());
            container.AddFacility<LoggingFacility>(f => f.UseLog4Net());
        }
    }
}