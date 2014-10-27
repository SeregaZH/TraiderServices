namespace TraiderInformationService.Core.Interfaces.Application
{
  public interface IApplicationMode
  {
    string ViewUriPrefix { get; }
    ApplicationModes Name { get; }
  }
}
