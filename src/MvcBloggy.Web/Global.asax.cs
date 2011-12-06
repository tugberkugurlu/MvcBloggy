using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Web.Optimization;
using MvcBloggy.Web.Application;
using MvcBloggy.Web.Application.RouteConstraints;
using MvcBloggy.Web.Application.Utility;

namespace MvcBloggy.Web {

    public class MvcApplication : System.Web.HttpApplication {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes) {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "DefaultRoute",
                "{language}/{controller}/{action}",
                new { controller = "default", action = "index" },
                new { language = new LanguageRouteConstraint() },
                new[] { "MvcBloggy.Web.Controllers" }
            );

            routes.MapRoute(
                "DefaultLangRoute",
                "{controller}/{action}",
                new { controller = "default", action = "index", language = AppLanguage.GetDefault() },
                new { },
                new[] { "MvcBloggy.Web.Controllers" }
            );

        }

        public static void RegisterBundles() {

            var appTheme = ConfigurationManager.AppSettings["AppDefaultTheme"];

            #region _v2 global css bundle

            var globalCSSBundlev2 = new Bundle(
                string.Format("~/themes/{0}/globalcss", appTheme),
                typeof(CssMinify)
            );

            //global ones
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part1.css");
            globalCSSBundlev2.AddFile(
                string.Format("~/themes/{0}/default.css", appTheme)
            );
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part2.css");

            BundleTable.Bundles.Add(globalCSSBundlev2);

            #endregion

            #region _v2 global js modernizr bundle

            var modernizrJSBundlev2 = new Bundle("~/scripts/v2/modernizr", typeof(JsMinify));

            modernizrJSBundlev2.AddFile("~/scripts/modernizr-2.0.6-development-only.js");

            BundleTable.Bundles.Add(modernizrJSBundlev2);

            #endregion

            #region _v2 global js bundle

            var globalJSBundlev2 = new Bundle("~/scripts/v2/globaljs", typeof(JsMinify));

            //global ones
            globalJSBundlev2.AddFile("~/scripts/jquery-ui-1.8.11.min.js");
            globalJSBundlev2.AddFile("~/scripts/plugins.js");
            globalJSBundlev2.AddFile("~/scripts/script.js");

            BundleTable.Bundles.Add(globalJSBundlev2);

            #endregion
        }

        protected void Application_Start() {

            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new LocalizedControllerFactory());

            RegisterBundles();
        }
    }
}