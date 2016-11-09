using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TwitterPage
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "FileProvider",
                url: "images/{name}",
                defaults: new { controller = "File", action = "GetFile" }
                );

            ////routes.MapRoute(
            ////    name: "Default",
            ////    url: "{controller}/{action}/{id}",
            ////    defaults: new { controller = "Main", action = "Index", id = UrlParameter.Optional }
            ////);



            //routes.MapRoute(
            //"ImageProvider",
            //"imagestore/{fileId}/",
            //new { controller = "File", action = "GetFile", id = UrlParameter.Optional });
        }
    }
}
