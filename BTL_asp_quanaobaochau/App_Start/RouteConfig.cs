using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BTL_asp_quanaobaochau
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "BTL_asp_quanaobaochau.Controllers" }
            );

            routes.MapRoute(
                name: "Nam",
                url: "Nam/{action}/{id}",
                defaults: new { controller = "Nam", action = "Index", id = UrlParameter.Optional }
                //namespaces: new string[] { "BTL_asp_quanaobaochau.Controllers" }
            );
        }
    }
}
