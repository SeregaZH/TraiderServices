using System.Configuration;
using System.Linq;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Configuration
{
  public sealed class ConfigurationManager : IConfigurationManager
  {
    public ApplicationModeElement GetActiveMode()
    {
      ApplicationModeElement result = null;
      var section = GetSection<ApplicationConfigurationSection>(
        ApplicationConfigurationSection.DefaultSectionName);
      
      foreach (var applicationModeNode in from object node in section.ApplicationModesCollection
        select node as ApplicationModeElement)
      {
        if (applicationModeNode == null)
          throw new ConfigurationErrorsException("invalid node in application cofiguration section");

        if (applicationModeNode.IsActive)
        {
          if (result != null)
          {
            throw new ConfigurationErrorsException("application modes can contain only one active node");
          }

          result = applicationModeNode;
        }
      }
      if (result == null)
        throw new ConfigurationErrorsException("application configuration should contain one active mode");

      return result;
    }

    private static TSection GetSection<TSection>(string name) where TSection : class
    {
      var configuration = System.Configuration.ConfigurationManager.GetSection(name) as TSection;
      if (configuration == null)
        throw new ConfigurationErrorsException(string.Format("section {0} not defined in config file", name));
      return configuration;
    }
  }
}
