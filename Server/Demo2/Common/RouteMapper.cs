using DotNetNuke.Web.Api;

namespace Bring2mind.Demo2025Mvc.Demo2.Common
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Bring2mind/Demo2", "Demo2Map1", "{controller}/{action}", null, null, new[] { "Bring2mind.Demo2025Mvc.Demo2.Api" });
            mapRouteManager.MapHttpRoute("Bring2mind/Demo2", "Demo2Map2", "{controller}/{action}/{id}", null, new { id = "-?\\d+" }, new[] { "Bring2mind.Demo2025Mvc.Demo2.Api" });
        }
    }
}