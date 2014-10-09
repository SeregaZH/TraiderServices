using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Bootstrap;
using TraiderInformationService.Core.Interfaces.Bootstrap;

namespace TraiderInformationService.Web.App_Start
{
  public sealed class UiBootstrapper : ModularityUnityBootstrapper
  {
    protected override void ConfigureContainer(IUnityContainer container)
    {
      base.ConfigureContainer(container);
      container.RegisterType<IApplicationManager, WebUiApplicationManager>(new ContainerControlledLifetimeManager());
    }
  }
}