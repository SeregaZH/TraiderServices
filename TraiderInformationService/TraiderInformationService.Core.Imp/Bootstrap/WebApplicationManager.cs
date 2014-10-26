using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Core.Modularity;

namespace TraiderInformationService.Core.Bootstrap
{
  public class WebApplicationManager : ModularityApplicationManager
  {
    public WebApplicationManager(IModuleCatalog moduleCatalog, IModuleManager moduleManager) 
      : base(moduleCatalog, moduleManager)
    {
    }

    protected override void ConfigureModules(IModuleCatalog moduleCatalog)
    {
      //register core modules here
    }

    protected override void Configure()
    {
      //register core static components and some other bootstrap code
    }
  }
}
