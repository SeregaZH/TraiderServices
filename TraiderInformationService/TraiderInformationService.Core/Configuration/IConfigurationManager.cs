namespace TraiderInformationService.Core.Interfaces.Configuration
{
  public interface IConfigurationManager
  {
    TSection GetSection<TSection>(string name)
      where TSection : class;
  }
}
