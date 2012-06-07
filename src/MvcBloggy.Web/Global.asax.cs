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

namespace MvcBloggy.Web {

    public class MvcApplication : System.Web.HttpApplication {

        protected void Application_Start() {

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