using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Web.Optimization;
using MvcBloggy.Web.Application;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MvcBloggy.Web.Bootstrapper), "Start")]
namespace MvcBloggy.Web {

    public class Bootstrapper {

        public static void Start() {

            Filters.RegisterGlobalFilters(GlobalFilters.Filters);
            Routes.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new LocalizedControllerFactory());

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CSRazorViewEngine());
        }
    }
}