using Microsoft.Practices.Unity;
using TraiderInformationService.Core.Bootstrap;
using TraiderInformationService.Core.Interfaces.Bootstrap;
using TraiderInformationService.Web.ViewEngines;

namespace TraiderInformationService.Web.App_Start
{
  public sealed class UiBootstrapper : WebUnityBootstrapper
  {
    protected override void ConfigureContainer(IUnityContainer container)
    {
      base.ConfigureContainer(container);
      container.RegisterType<AngularViewEngine, AngularViewEngine>(new ContainerControlledLifetimeManager());
      container.RegisterType<IApplicationManager, WebUiApplicationManager>(new ContainerControlledLifetimeManager());
    }
  }
}