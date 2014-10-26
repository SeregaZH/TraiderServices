using System;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;

namespace TraiderInformationService.Core.Application
{
  public class ApplicationContext : IApplicationContext
  {
    private Lazy<ApplicationMode> _applicationMode;
    private readonly IConfigurationManager _configurationManager;

    public ApplicationContext(IConfigurationManager configurationManager)
    {
      _configurationManager = configurationManager;
      Init();
    }

    public ApplicationMode Mode
    {
      get
      {
        return _applicationMode.Value;
      }
    }

    private void Init()
    {
      _applicationMode = new Lazy<ApplicationMode>(() => new ApplicationMode(_configurationManager.GetActiveMode()));
    }
  }
}
