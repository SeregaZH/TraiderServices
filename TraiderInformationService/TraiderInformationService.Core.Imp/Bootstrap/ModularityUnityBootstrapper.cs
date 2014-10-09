using System;
using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Bootstrap
{
  public class ModularityUnityBootstrapper : UnityMvcBootstrapper
  {
    protected override void ConfigureContainer(IUnityContainer container)
    {
      container.RegisterInstance<IModuleCatalog>(new ModuleCatalog());
      container.RegisterInstance<IModuleManager>(new ModuleManager());
    }
  }
}
