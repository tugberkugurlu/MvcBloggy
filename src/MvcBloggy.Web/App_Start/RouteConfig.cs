using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using MvcBloggy.Web.Infrastructure.Mvc;
using MvcBloggy.Web.Infrastructure.Utility;
using MvcBloggy.Web.Infrastructure;
using MvcBloggy.Web.Infrastructure.MetaWeblogItems;

namespace MvcBloggy.Web {

    public class RouteConfig {

        public static void RegisterRoutes(RouteCollection routes) {

            routes.IgnoreRoute("content/{*pathInfo}");
            routes.IgnoreRoute("scripts/{*pathInfo}");
            routes.IgnoreRoute("themes/{*pathInfo}");
            routes.IgnoreRoute("{*allico}", new { allico = @".*\.ico(/.*)?" });

            routes.IgnoreRoute("{file}.txt");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //http://www.cookcomputing.com/blog/archives/xml-rpc-and-asp-net-mvc
            routes.MapLowerCaseRoute("wlwmanifest.xml", new { controller = "MetaWeblog", action = "WlwManifest" });
            routes.Add(new Route("{weblog}", new RouteValueDictionary(new { language = AppLanguage.GetDefault() }), new RouteValueDictionary(new { weblog = "blogapi" }), new MetaWeblogRouteHandler()));
            routes.Add(new Route("{weblog}/{language}", null, new RouteValueDictionary(new { weblog = "blogapi", language = new LanguageRouteConstraint() }), new MetaWeblogRouteHandler()));

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