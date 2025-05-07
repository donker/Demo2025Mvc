using DotNetNuke.Web.Mvc.Framework.Controllers;
using DotNetNuke.Web.Mvc.Routing;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bring2mind.Demo2025Mvc.Demo1.Common
{
    public class Demo1MvcController : DnnController
    {

        private ContextHelper _Demo1ModuleContext;
        public ContextHelper Demo1ModuleContext
        {
            get { return _Demo1ModuleContext ?? (_Demo1ModuleContext = new ContextHelper(this)); }
        }

    }
}