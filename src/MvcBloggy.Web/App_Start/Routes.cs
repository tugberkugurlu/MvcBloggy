using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using MvcBloggy.Web.Application.Mvc;
using MvcBloggy.Web.Application.Utility;

namespace MvcBloggy.Web {

    public class Routes {

        public static void RegisterRoutes(RouteCollection routes) {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //http://www.cookcomputing.com/blog/archives/xml-rpc-and-asp-net-mvc
            routes.MapLowerCaseRoute("wlwmanifest.xml", new { controller = "MetaWeblog", action = "WlwManifest" });

            //default routes
            routes.MapRoute(
                "DefaultRoute",
                "{language}/{controller}/{action}",
                new { controller = "default", action = "index" },
                new { language = new LanguageRouteConstraint() },
                new string[] { "MvcBloggy.Web.Controllers" }
            );

            routes.MapRoute(
                "DefaultLangRoute",
                "{controller}/{action}",
                new { controller = "default", action = "index", language = AppLanguage.GetDefault() },
                new { },
                new string[] { "MvcBloggy.Web.Controllers" }
            );

        }
    }
}