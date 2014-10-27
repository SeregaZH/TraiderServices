using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Application
{
  public sealed class ApplicationModeWrapper : IApplicationMode
  {
    private readonly ApplicationMode _applicationMode;

    public ApplicationModeWrapper()
    {
      
    }

    internal ApplicationModeWrapper(ApplicationMode applicationMode)
    {
      _applicationMode = applicationMode;
    }

    public string ViewUriPrefix
    {
      get { return _applicationMode.ViewUriPrefix; }
    }

    public ApplicationModes Name
    {
      get { return _applicationMode.Name; }
    }
  }
}
