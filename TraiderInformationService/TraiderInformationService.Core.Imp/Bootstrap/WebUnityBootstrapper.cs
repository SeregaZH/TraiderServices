using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Application;
using TraiderInformationService.Core.Configuration;
using TraiderInformationService.Core.Interfaces;
using TraiderInformationService.Core.Interfaces.Configuration;
using TraiderInformationService.Core.Mapper;

namespace TraiderInformationService.Core.Bootstrap
{
  public class WebUnityBootstrapper : ModularityUnityBootstrapper
  {
    protected override void ConfigureContainer(IUnityContainer container)
    {
      base.ConfigureContainer(container);
      container.RegisterType<IConfigurationManager, ConfigurationManager>();
      container.RegisterType<IApplicationContext, ApplicationContext>();
      container.RegisterType<IMapperFactory, MapperFactory>();
    }
  }
}
