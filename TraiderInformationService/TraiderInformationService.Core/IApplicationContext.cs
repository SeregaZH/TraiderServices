using TraiderInformationService.Core.Interfaces.Application;

namespace TraiderInformationService.Core.Interfaces
{
  public interface IApplicationContext
  {
    IApplicationMode Mode { get; }
  }
}
