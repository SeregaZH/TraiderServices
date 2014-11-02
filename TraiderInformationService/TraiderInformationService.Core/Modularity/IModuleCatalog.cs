using System.Collections.Generic;

namespace TraiderInformationService.Core.Interfaces.Modularity
{
  public interface IModuleCatalog : IEnumerable<IModuleInfo>
  {
    void RegisterModule(IModuleInfo module);
  }
}
