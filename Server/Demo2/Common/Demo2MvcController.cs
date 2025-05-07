using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Web.Mvc.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bring2mind.Demo2025Mvc.Demo2.Common
{
    public class Demo2MvcController : DnnController
    {

        private ContextHelper _Demo2ModuleContext;
        public ContextHelper Demo2ModuleContext
        {
            get { return _Demo2ModuleContext ?? (_Demo2ModuleContext = new ContextHelper(this)); }
        }

    }
}