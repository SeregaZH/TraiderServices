using TraiderInformationService.Core.Interfaces.Bootstrap;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public abstract class ModularityApplicationManager : IApplicationManager
  {
    private readonly IModuleCatalog _moduleCatalog;
    private readonly IModuleManager _moduleManager;

    protected ModularityApplicationManager(
      IModuleCatalog moduleCatalog, 
      IModuleManager moduleManager)
    {
      _moduleCatalog = moduleCatalog;
      _moduleManager = moduleManager;
    }

    public void ConfigureApplication()
    {
      ConfigureModules(_moduleCatalog);
      
      _moduleManager.InitializeModules(_moduleCatalog);
      
      Configure();
    }

    protected abstract void ConfigureModules(IModuleCatalog moduleCatalog);
    protected abstract void Configure();
  }
}
