using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MvcBloggy.Web {

    public class BundleConfig {

        public static void RegisterBundles(BundleCollection bundles) {

            var appTheme = ConfigurationManager.AppSettings["AppDefaultTheme"];

            bundles.Add(new ScriptBundle("~/assets/js/globaljs").Include(
                    "~/scripts/jquery-1.8.0.js",
                    "~/scripts/jquery.validate.js",
                    "~/scripts/jquery.validate.unobtrusive.js",
                    "~/scripts/bootstrap.js",
                    "~/scripts/plugins.js",
                    "~/scripts/script.js",
                    string.Format("~/themes/{0}/scripts/plugins.js", appTheme),
                    string.Format("~/themes/{0}/scripts/script.js", appTheme)
                )
            );

            bundles.Add(new ScriptBundle("~/assets/js/modernizr").Include(
                    "~/scripts/modernizr-2.5.3.js"
                )
            );

            bundles.Add(new StyleBundle(string.Format("~/themes/{0}/globalcss", appTheme)).Include(
                    "~/content/bootstrap.css",
                    "~/content/bootstrap-responsive.css",
                    "~/content/style.css",
                    string.Format("~/themes/{0}/default.css", appTheme),
                    string.Format("~/themes/{0}/default.media.css", appTheme)
                )
            );
        }
    }
}