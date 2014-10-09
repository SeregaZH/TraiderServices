using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;

namespace TraiderInformationService.Core.Application
{
  public class ApplicationContext : IApplicationContext
  {
    private readonly IConfigurationManager _configurationManager;

    protected ApplicationContext()
    {
      Init();
    }
    
    public ApplicationContext(IConfigurationManager configurationManager)
      :this()
    {
      _configurationManager = configurationManager;
    }

    public ApplicationMode Mode { get; private set; }
    
    private void Init()
    {
      Mode = new ApplicationMode(_configurationManager.GetActiveMode());
    }
  }
}
