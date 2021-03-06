﻿using System.Configuration;

namespace TraiderInformationService.Core.Interfaces.Configuration.Sections
{
  public class ApplicationModeElement : ConfigurationElement
  {
    [ConfigurationProperty("name", DefaultValue = "dev", IsKey = true, IsRequired = true)]
    public string Name
    {
      get { return ((string)(base["name"])); }
      set { base["name"] = value; }
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
