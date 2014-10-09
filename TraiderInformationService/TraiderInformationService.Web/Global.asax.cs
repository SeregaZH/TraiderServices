using TraiderInformationService.Web.App_Start;

namespace TraiderInformationService.Web
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {
      var bootstrapper = new UiBootstrapper();
      bootstrapper.Bootstrap();
    }
  }
}