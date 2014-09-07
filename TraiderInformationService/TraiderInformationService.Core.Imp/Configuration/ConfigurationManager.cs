using System.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration;

namespace TraiderInformationService.Core.Imp.Configuration
{
  public sealed class ConfigurationManager : IConfigurationManager
  {
    public TSection GetSection<TSection>(string name) where TSection : class
    {
      var configuration = System.Configuration.ConfigurationManager.GetSection(name) as TSection;
      if (configuration == null)
        throw new ConfigurationErrorsException(string.Format("section {0} not defined in config file", name));
      return configuration;
    }
  }
}
