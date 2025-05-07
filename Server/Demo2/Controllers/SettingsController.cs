using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using Bring2mind.Demo2025Mvc.Demo2.Common;
using System.Web.Mvc;

namespace Bring2mind.Demo2025Mvc.Demo2.Controllers
{
    [DnnModuleAuthorize(AccessLevel = DotNetNuke.Security.SecurityAccessLevel.Edit)]
    [DnnHandleError]
    public class SettingsController : Demo2MvcController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Settings()
        {
            return View(Demo2ModuleContext.Settings);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="supportsTokens"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateInput(false)]
        [DotNetNuke.Web.Mvc.Framework.ActionFilters.ValidateAntiForgeryToken]
        public ActionResult Settings(ModuleSettings settings)
        {
            settings.SaveSettings(ModuleContext.Configuration);
            return RedirectToDefaultRoute();
        }
    }
}