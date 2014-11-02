using System;
using System.Collections;
using System.Collections.Generic;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleCatalog : IModuleCatalog
  {
    private readonly LinkedList<IModuleInfo> _catalog;

    public ModuleCatalog()
    {
      _catalog = new LinkedList<IModuleInfo>();
    }

    public void RegisterModule(IModuleInfo module)
    {
      if (module == null)
      {
        throw new ArgumentNullException("module");
      }

      _catalog.AddLast(module);
    }

    public IEnumerator<IModuleInfo> GetEnumerator()
    {
      return _catalog.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
