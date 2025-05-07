using DotNetNuke.Web.Api;

namespace Bring2mind.Demo2025Mvc.Demo1.Common
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute("Bring2mind/Demo1", "Demo1Map1", "{controller}/{action}", null, null, new[] { "Bring2mind.Demo2025Mvc.Demo1.Api" });
            mapRouteManager.MapHttpRoute("Bring2mind/Demo1", "Demo1Map2", "{controller}/{action}/{id}", null, new { id = "-?\\d+" }, new[] { "Bring2mind.Demo2025Mvc.Demo1.Api" });
        }
    }
}