using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetNuke.Web.Api;
using System.Diagnostics;

namespace DAFF.Modules.Dnn.DAFF.ReceptValaszto.Components
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
               "ReceptValaszto",
               "default",
               "{controller}/{action}",
               new string[] { "DAFF.Modules.Dnn.DAFF.ReceptValaszto.Controllers.Api" });
        }
    }
}