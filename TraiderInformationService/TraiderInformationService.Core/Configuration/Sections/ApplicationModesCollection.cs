using System.Configuration;

namespace TraiderInformationService.Core.Interfaces.Configuration.Sections
{
  public class ApplicationModesCollection : ConfigurationElementCollection
  {
    protected override ConfigurationElement CreateNewElement()
    {
      return new ApplicationModeElement();
    }

    protected override object GetElementKey(ConfigurationElement element)
    {
      return ((ApplicationModeElement)element).Name;
    }
  }
}
