using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Interfaces.Configuration
{
  public interface IConfigurationManager
  {
    ApplicationModeElement GetActiveMode();
  }
}
