using System.Configuration;

namespace TraiderInformationService.Core.Interfaces.Configuration.Sections
{
  public class ApplicationConfigurationSection : ConfigurationSection
  {
    public const string DefaultSectionName = "applicationConfig";
    
    [ConfigurationProperty("applicationModes")]
    public ApplicationModesCollection ApplicationModesCollection
    {
      get
      {
        return ((ApplicationModesCollection)(base["applicationModes"]));
      }
    }
  }
}
