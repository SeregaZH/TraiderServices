using System.Collections.Generic;

namespace TraiderInformationService.Core.Interfaces.Modularity
{
  public interface IModuleCatalog
  {
    void RegisterModule(IModule module);
    IEnumerable<IModule> GetModules();
  }
}
