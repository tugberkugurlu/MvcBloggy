using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Optimization;
using MvcBloggy.Web.Application.Mvc;
using MvcBloggy.Web.Application;
using MvcBloggy.Web.Application.Utility;
using System.Web.Http;

namespace MvcBloggy.Web {

    public class MvcApplication : System.Web.HttpApplication {

        protected void Application_Start() {

            //WebAPIConfig
            var config = GlobalConfiguration.Configuration;
            MvcBloggy.API.Config.AutofacWebAPI.Initialize(config);
            MvcBloggy.API.Config.RouteConfig.RegisterRoutes(config.Routes);
            MvcBloggy.API.Config.WebAPIConfig.Configure(config);

            AreaRegistration.RegisterAllAreas();
            AutofacMVC3.Initialize();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ControllerBuilder.Current.SetControllerFactory(new LocalizedControllerFactory());
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CSRazorViewEngine());
        }
    }
}