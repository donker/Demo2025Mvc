using DotNetNuke.Web.MvcPipeline.Routing;

namespace Bring2mind.Demo2025Mvc.Demo2.Common
{
  public class RouteConfig : IMvcRouteMapper
  {
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
      mapRouteManager.MapRoute(
          "Bring2mind/Demo2",
          "MvcPipelineDemo2Map1",
          "{controller}/{action}",
          null,
          null,
          new[] { "Bring2mind.Demo2025Mvc.Demo2.Controllers" });

      mapRouteManager.MapRoute(
          "Bring2mind/Demo2",
          "MvcPipelineDemo2Map2",
          "{controller}/{action}/{id}",
          null,
          new { id = "-?\\d+" },
          new[] { "Bring2mind.Demo2025Mvc.Demo2.Controllers" });
    }
  }
}
