using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StoreMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null,"", defaults: new { controller = "Prod", action = "List", category = string.Empty });
            routes.MapRoute(null, "{category}", defaults: new { controller = "Prod", action = "List" });
            routes.MapRoute(null, "{controller}/{action}");
        }
    }
}
