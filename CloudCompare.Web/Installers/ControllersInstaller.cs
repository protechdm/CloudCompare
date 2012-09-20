using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using CloudCompare.Domain.Contracts.Repositories;
using CloudCompare.POCOQueryRepository;

namespace CloudCompare.Web.Installers
{
    public class ControllersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromThisAssembly()
                                .BasedOn<IController>()
                                .LifestyleTransient());

            container.Register(Component
.For<ICloudCompareContext>()
.ImplementedBy<CloudCompareContext>()
.LifestyleScoped<WebSessionScopeAccessor>());

            container.Register(Component
.For<ICloudCompareRepository>()
.ImplementedBy<QueryRepository>()
.LifestyleScoped<WebSessionScopeAccessor>());

        }
    }
}