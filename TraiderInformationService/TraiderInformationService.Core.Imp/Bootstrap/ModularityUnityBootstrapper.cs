using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Bootstrap
{
  public class ModularityUnityBootstrapper : UnityMvcBootstrapper
  {
    protected override void ConfigureContainer(IUnityContainer container)
    {
      container.RegisterType<IModuleCatalog, ModuleCatalog>(new ContainerControlledLifetimeManager());
      container.RegisterType<IModuleManager, ModuleManager>(new ContainerControlledLifetimeManager());
    }
  }
}
