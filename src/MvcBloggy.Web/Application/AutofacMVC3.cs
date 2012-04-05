using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MvcBloggy.Data.DataAccess.Infrastructure;
using MvcBloggy.Data.DataAccess.SqlServer;
using MvcBloggy.Web;
using MvcBloggy.Web.Application.Services;

namespace MvcBloggy.Web.Application {

    internal class AutofacMVC3 {

        public static void Initialize() {

            var builder = new ContainerBuilder();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(RegisterServices(builder)));
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            builder.RegisterType<BlogPostRepository>().As<IBlogPostRepository>().SingleInstance();
            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance();

            builder.RegisterType<FormsAuthenticationService>().As<IFormsAuthenticationService>().SingleInstance();
            builder.RegisterType<AuthorizationService>()
                .As<IAuthorizationService>()
                .UsingConstructor(typeof(IUserRepository))
                .SingleInstance();

            return
                builder.Build();
        }
    }
}