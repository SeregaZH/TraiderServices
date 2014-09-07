using System.Web.Mvc;

namespace TraiderInformationService.Web.Controllers.Security
{
  public class SecurityController : Controller
  {
    public ActionResult Login()
    {
      return View();
    }

    public ActionResult Register()
    {
      return View();
    }
  }
}