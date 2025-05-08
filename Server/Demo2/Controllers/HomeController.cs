using System.Web.Mvc;
using Bring2mind.Demo2025Mvc.Demo2.Common;

namespace Bring2mind.Demo2025Mvc.Demo2.Controllers
{
  public class HomeController : Demo2MvcController
  {
    [HttpGet]
    public ActionResult Index()
    {
      return View(Demo2ModuleContext.Settings.View);
    }
  }
}
