using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Interfaces
{
  public interface IApplicationContext
  {
    ApplicationMode Mode { get; }
  }
}
