using System;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleManager : IModuleManager
  {
    public void InitializeModules(IModuleCatalog modulesCatalog)
    {
      if (modulesCatalog == null)
      {
        throw new ArgumentNullException("modulesCatalog");
      }

      foreach(var catalog in modulesCatalog)
      {
        catalog.Initialize();
      }
    }
  }
}
