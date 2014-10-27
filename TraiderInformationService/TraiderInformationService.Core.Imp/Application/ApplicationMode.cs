using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Application
{
  internal sealed class ApplicationMode
  {
    public string ViewUriPrefix { get; set; }

    public ApplicationModes Name { get; set; }
  }
}
