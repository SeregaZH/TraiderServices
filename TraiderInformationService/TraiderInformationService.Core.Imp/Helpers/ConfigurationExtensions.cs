using System.Configuration;
using System.Linq;
using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Imp.Helpers
{
  internal static class ConfigurationExtensions
  {
    public static ApplicationModeElement GetActiveMode(this ApplicationConfigurationSection @this)
    {
      ApplicationModeElement result = null;
      foreach (var applicationModeNode in from object node in @this.ApplicationModesCollection
                                          select node as ApplicationModeElement)
      {
        if(applicationModeNode == null)
          throw new ConfigurationErrorsException("invalid node in application cofiguration section");

        if (applicationModeNode.IsActive)
        {
          if (result != null)
          {
            throw new ConfigurationErrorsException("application modes can contain only one node");
          }

          result = applicationModeNode;
        }
      }
      if(result == null)
        throw new ConfigurationErrorsException("application configuration should contain one active mode");

      return result;
    }
  }
}
