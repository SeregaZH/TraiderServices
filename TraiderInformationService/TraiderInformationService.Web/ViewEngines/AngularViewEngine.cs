using System.Web.Mvc;
using TraiderInformationService.Core.Interfaces;

namespace TraiderInformationService.Web.ViewEngines
{
  public class AngularViewEngine : VirtualPathProviderViewEngine  
  {
    public AngularViewEngine(IApplicationContext applicationContext)
    {
      ViewLocationFormats = new[]
      {
        "~/" + applicationContext.Mode.ViewUriPrefix +"/views/{1}/{0}.html",
        "~/" + applicationContext.Mode.ViewUriPrefix +"/views/{0}.html",
        "~/" + applicationContext.Mode.ViewUriPrefix +"/{0}.html"
      };
    }

    protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
    {
      var physicalpath = controllerContext.HttpContext.Server.MapPath(partialPath);
      return new HtmlView(physicalpath);
    }

    protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
    {
      var physicalpath = controllerContext.HttpContext.Server.MapPath(viewPath);
      return new HtmlView(physicalpath);
    }
  }
}