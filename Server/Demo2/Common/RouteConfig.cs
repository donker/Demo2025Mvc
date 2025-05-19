using DotNetNuke.Instrumentation;
using DotNetNuke.Web.MvcPipeline.Routing;

namespace Bring2mind.Demo2025Mvc.Demo2.Common
{
  public class RouteConfig : IMvcRouteMapper
  {
    public static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(RouteConfig));
    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
      Logger.Info("Registering routes for Bring2mind/Demo2");
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
