using DotNetNuke.Web.MvcPipeline.Routing;

namespace Bring2mind.Demo2025Mvc.Demo1.Common
{
  public class RouteConfig : IMvcRouteMapper
  {
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
      mapRouteManager.MapRoute(
          "Bring2mind_Demo1",
          "MvcPipelineDemo1Map1",
          "{controller}/{action}",
          null,
          null,
          new[] { "Bring2mind.Demo2025Mvc.Demo1.Controllers" });

      mapRouteManager.MapRoute(
          "Bring2mind_Demo1",
          "MvcPipelineDemo1Map2",
          "{controller}/{action}/{id}",
          null,
          new { id = "-?\\d+" },
          new[] { "Bring2mind.Demo2025Mvc.Demo1.Controllers" });
    }
  }
}
