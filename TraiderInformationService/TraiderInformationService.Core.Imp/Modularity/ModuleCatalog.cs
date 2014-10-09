using System.Collections.Generic;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleCatalog : IModuleCatalog
  {
    private readonly IList<IModule> _catalog;

    public ModuleCatalog()
    {
      _catalog = new List<IModule>();
    }

    public void RegisterModule(IModule module)
    {
      _catalog.Add(module);
    }

    public IEnumerable<IModule> GetModules()
    {
      return _catalog;
    }
  }
}
