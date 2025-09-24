using Bring2mind.Demo2025Mvc.Demo1.Common;
using DotNetNuke.Entities.Users;
using System.Web.Mvc;

namespace Bring2mind.Demo2025Mvc.Demo1.Controllers
{
  public class BarController : Demo1MvcController
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
      var newEmail = data.Email;
      var user = UserController.GetUserById(PortalSettings.PortalId, userId);
      if (user != null && user.UserID > 0)
      {
        user.Email = newEmail;
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
