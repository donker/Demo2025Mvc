using System.Web.Mvc;
using Bring2mind.Demo2025Mvc.Demo1.Common;

namespace Bring2mind.Demo2025Mvc.Demo1.Controllers
{
  public class HomeController : Demo1MvcController
  {
    [HttpGet]
    public ActionResult Index()
    {
      return View(Demo1ModuleContext.Settings.View);
    }
  }
}
