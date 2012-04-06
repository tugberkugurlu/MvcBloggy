using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Web.Optimization;
using MvcBloggy.Web.Application.Mvc;
using MvcBloggy.Web.Application;
using MvcBloggy.Web.Application.Utility;

namespace MvcBloggy.Web {

    public class MvcApplication : System.Web.HttpApplication {

        public static void RegisterBundles(BundleCollection bundles) {

            var appTheme = ConfigurationManager.AppSettings["AppDefaultTheme"];

            #region _v2 global css bundle

            var globalCSSBundlev2 = new Bundle(
                string.Format("~/themes/{0}/globalcss", appTheme),
                typeof(CssMinify)
            );

            //before defaults
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part1.css");
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part2.mvcbloggy.css");

            //theme styles
            globalCSSBundlev2.AddFile(
                string.Format("~/themes/{0}/default.css", appTheme)
            );
            globalCSSBundlev2.AddFile(
                string.Format("~/themes/{0}/default.media.css", appTheme)
            );

            //after defaults
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part3.css");
            globalCSSBundlev2.AddFile("~/content/v2/css/boilerplate-part4.print.css");

            bundles.Add(globalCSSBundlev2);

            #endregion

            #region _v2 global js modernizr bundle

            var modernizrJSBundlev2 = new Bundle("~/scripts/v2/modernizr", typeof(JsMinify));

            modernizrJSBundlev2.AddFile("~/scripts/modernizr-2.0.6-development-only.js");

            bundles.Add(modernizrJSBundlev2);

            #endregion

            #region _v2 global js bundle

            var globalJSBundlev2 = new Bundle("~/scripts/v2/globaljs", typeof(JsMinify));

            //before defaults
            //globalJSBundlev2.AddFile("~/scripts/jquery-ui-1.8.11.min.js");
            globalJSBundlev2.AddFile("~/scripts/plugins.js");
            globalJSBundlev2.AddFile("~/scripts/script.js");

            //theme scripts
            globalJSBundlev2.AddFile(
                string.Format("~/themes/{0}/scripts/plugins.js", appTheme)
            );
            globalJSBundlev2.AddFile(
                string.Format("~/themes/{0}/scripts/script.js", appTheme)
            );

            bundles.Add(globalJSBundlev2);

            #endregion
        }

        protected void Application_Start() {

            RegisterBundles(BundleTable.Bundles);
        }

    }
}