using System;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleManager : IModuleManager
  {
    private readonly IModuleInitializer _moduleInitializer;

    public ModuleManager(IModuleInitializer moduleInitializer)
    {
      _moduleInitializer = moduleInitializer;
    }

    public void InitializeModules(IModuleCatalog modulesCatalog)
    {
      if (modulesCatalog == null)
      {
        throw new ArgumentNullException("modulesCatalog");
      }

      foreach(var catalog in modulesCatalog)
      {
        _moduleInitializer.IntializeModule(catalog);
      }
    }
  }
}
