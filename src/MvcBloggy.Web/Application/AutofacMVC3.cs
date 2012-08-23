using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MvcBloggy.Web;
using MvcBloggy.Web.Application.Services;
using MvcBloggy.Web.Application.MetaWeblogItems;

namespace MvcBloggy.Web.Application {

    internal class AutofacMVC3 {

        public static void Initialize() {

            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            //services
            builder.RegisterType<ApplicationSettings>().As<IApplicationSettings>().InstancePerHttpRequest().SingleInstance();
            builder.RegisterType<FormsAuthenticationService>().As<IFormsAuthenticationService>().InstancePerHttpRequest();
            builder.RegisterType<BlogHttpClient>().As<IBlogHttpClient>();

            //core
            builder.RegisterType<MetaWeblog>().As<IMetaWeblog>().InstancePerLifetimeScope();

            return builder.Build();
        }
    }
}