using System.Collections.Generic;

namespace TraiderInformationService.Core.Interfaces.Modularity
{
  public interface IModuleCatalog : IEnumerable<IModule>
  {
    void RegisterModule(IModule module);
  }
}
