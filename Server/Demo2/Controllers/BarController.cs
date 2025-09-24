using Bring2mind.Demo2025Mvc.Demo2.Common;
using DotNetNuke.Entities.Users;
using System.Web.Mvc;

namespace Bring2mind.Demo2025Mvc.Demo2.Controllers
{
  public class BarController : Demo2MvcController
  {
    [HttpGet]
    public ActionResult Index(int userId)
    {
      var user = UserController.GetUserById(PortalSettings.PortalId, userId);
      return View(user);
    }
  }
}
