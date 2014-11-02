using System;
using TraiderInformationService.Core.Interfaces.Modularity;

namespace TraiderInformationService.Core.Modularity
{
  public class ModuleInitializer : IModuleInitializer
  {
    private readonly IModuleCreator _moduleCreator;

    public ModuleInitializer(IModuleCreator moduleCreator)
    {
      _moduleCreator = moduleCreator;
    }

    public void IntializeModule(IModuleInfo moduleInfo)
    {
      if (moduleInfo == null)
      {
        throw new ArgumentNullException("moduleInfo");
      }

      var module = _moduleCreator.Create(moduleInfo);
      module.Initialize();
    }
  }
}
