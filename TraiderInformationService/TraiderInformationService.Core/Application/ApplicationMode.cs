using TraiderInformationService.Core.Interfaces.Configuration.Sections;

namespace TraiderInformationService.Core.Interfaces.Application
{
  public sealed class ApplicationMode
  {
    public ApplicationMode()
    {
      
    }

    public ApplicationMode(ApplicationModeElement config)
    {
      Name = config.Name;
      ViewUriPrefix = config.UriPrefix;
    }

    public string ViewUriPrefix { get; private set; }
    public ApplicationModes Name { get; private set; }
  }
}
