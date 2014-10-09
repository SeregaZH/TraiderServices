using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using TraiderInformationService.Core.Bootstrap;
using TraiderInformationService.Core.Interfaces.Modularity;
using TraiderInformationService.Web.ViewEngines;

namespace TraiderInformationService.Web.App_Start
{
  public sealed class WebUiApplicationManager : WebApplicationManager
  {
    public WebUiApplicationManager(
      IModuleCatalog moduleCatalog, 
      IModuleManager moduleManager) 
      : base(moduleCatalog, moduleManager)
    {
    }

    protected override void Configure()
    {
      base.Configure();
      AreaRegistration.RegisterAllAreas();

      WebApiConfig.Register(GlobalConfiguration.Configuration);
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      System.Web.Mvc.ViewEngines.Engines.Add(new AngularViewEngine());
    }
  }
}