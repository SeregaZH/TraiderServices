using TraiderInformationService.Core.Imp.Helpers;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Application;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Imp.Application
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
      var section = _configurationManager.GetSection<ApplicationConfigurationSection>(
        ApplicationConfigurationSection.DefaultSectionName);
      Mode = new ApplicationMode(section.GetActiveMode());
    }
  }
}
