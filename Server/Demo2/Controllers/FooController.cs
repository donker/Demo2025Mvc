using System.Web.Mvc;
using Bring2mind.Demo2025Mvc.Demo2.Common;
using DotNetNuke.Entities.Users;

namespace Bring2mind.Demo2025Mvc.Demo2.Controllers
{
  public class FooController : Demo2MvcController
  {
    [HttpGet]
    public ActionResult Index(int userId)
    {
      var user = UserController.GetUserById(PortalSettings.PortalId, userId);
      return View(user);
    }

    [HttpPost]
    public ActionResult Index(int userId, UserInfo data)
    {
      var newUserDisplayName = data.DisplayName;
      var user = UserController.GetUserById(PortalSettings.PortalId, userId);
      if (user != null && user.UserID > 0)
      {
        user.DisplayName = newUserDisplayName;
        UserController.UpdateUser(PortalSettings.PortalId, user);
      }
      else
      {
        // Handle the case where the user does not exist
        ModelState.AddModelError("", "User not found.");
        return View(data);
      }
      return RedirectToDefaultRoute();
    }
  }
}
