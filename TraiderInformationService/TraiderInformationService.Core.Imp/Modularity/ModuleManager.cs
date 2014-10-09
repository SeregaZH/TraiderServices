using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleManager : IModuleManager
  {
    public void InitializeModules(IModuleCatalog modulesCatalog)
    {
      foreach(var catalog in modulesCatalog.GetModules())
      {
        catalog.Initialize();
      }
    }
  }
}
