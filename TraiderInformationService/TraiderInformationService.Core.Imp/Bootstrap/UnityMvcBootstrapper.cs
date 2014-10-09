using System;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using TraiderInformationService.Core.Interfaces.Bootstrap;

namespace TraiderInformationService.Core.Bootstrap
{
  public abstract class UnityMvcBootstrapper : Bootstrapper
  {
    protected override void ConfigureServiceLocator()
    {
      var container = CreateContainer();
      ConfigureContainer(container);
      var resolver = new UnityDependencyResolver(container);
      DependencyResolver.SetResolver(resolver);
    }

    protected override void ConfigureApplication()
    {
      var applicationManager = DependencyResolver.Current.GetService<IApplicationManager>();
      if (applicationManager == null)
      { 
        throw new InvalidOperationException("application doesn't configure");
      }

      applicationManager.ConfigureApplication();
    }

    protected abstract void ConfigureContainer(IUnityContainer container);

    private IUnityContainer CreateContainer()
    {
      return new UnityContainer();
    }
  }
}
