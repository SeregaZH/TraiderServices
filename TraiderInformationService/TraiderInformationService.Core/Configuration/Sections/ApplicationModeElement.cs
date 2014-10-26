using System;
using System.Configuration;
using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Interfaces.Configuration.Sections
{
  public class ApplicationModeElement : ConfigurationElement
  {
    [ConfigurationProperty("name", DefaultValue = ApplicationModes.Dev, IsKey = true, IsRequired = true)]
    public ApplicationModes Name
    {
      get
      {
        ApplicationModes result;
        if (!Enum.TryParse(((string)base["name"]), out result))
          throw new ConfigurationErrorsException("Can't construct mode name, application mode is invalid");
        return result;
      }
      set
      {
        var newValue = Enum.GetName(typeof(ApplicationModes), value);
        base["name"] = newValue;
      }
    }

    [ConfigurationProperty("uriPrefix", DefaultValue = "", IsKey = false, IsRequired = true)]
    public string UriPrefix
    {
      get { return ((string)(base["uriPrefix"])); }
      set { base["uriPrefix"] = value; }
    }

    [ConfigurationProperty("active", DefaultValue = false, IsKey = false, IsRequired = true)]
    public bool IsActive
    {
      get { return ((bool)(base["active"])); }
      set { base["active"] = value; }
    }
  }
}
