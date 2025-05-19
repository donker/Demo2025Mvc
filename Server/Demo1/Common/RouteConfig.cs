using DotNetNuke.Instrumentation;
using DotNetNuke.Web.MvcPipeline.Routing;

namespace Bring2mind.Demo2025Mvc.Demo1.Common
{
  public class RouteConfig : IMvcRouteMapper
  {
    public static readonly ILog Logger = LoggerSource.Instance.GetLogger(typeof(RouteConfig));

    public void RegisterRoutes(IMapRoute mapRouteManager)
    {
      Logger.Info("Registering routes for Bring2mind/Demo1");
      mapRouteManager.MapRoute(
          "Bring2mind/Demo1",
          "MvcPipelineDemo1Map1",
          "{controller}/{action}",
          null,
          null,
          new[] { "Bring2mind.Demo2025Mvc.Demo1.Controllers" });

      mapRouteManager.MapRoute(
          "Bring2mind/Demo1",
          "MvcPipelineDemo1Map2",
          "{controller}/{action}/{id}",
          null,
          new { id = "-?\\d+" },
          new[] { "Bring2mind.Demo2025Mvc.Demo1.Controllers" });
    }
  }
}
