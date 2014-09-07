using System.Web.Mvc;

namespace TraiderInformationService.Web.ViewEngines
{
  //todo inject application context 
  public class AngularViewEngine : VirtualPathProviderViewEngine  
  {
    public AngularViewEngine()
    {
      ViewLocationFormats = new[]
      {
        "~/application/dev/views/{1}/{0}.html",
        "~/application/dev/views/{0}.html",
        "~/application/dev/{0}.html"
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