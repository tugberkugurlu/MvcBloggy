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

            //services
            builder.RegisterType<FormsAuthenticationService>().As<IFormsAuthenticationService>().SingleInstance();
            builder.RegisterType<AuthorizationService>()
                .As<IAuthorizationService>()
                .UsingConstructor(typeof(IUserRepository))
                .InstancePerLifetimeScope();

            //repositories
            builder.RegisterType<BlogPostRepository>().As<IBlogPostRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BlogPostCommentRepository>().As<IBlogPostCommentRepository>().InstancePerLifetimeScope();
            builder.RegisterType<TagRepository>().As<ITagRepository>().InstancePerLifetimeScope();
            builder.RegisterType<DynamicPageRepository>().As<IDynamicPageRepository>().InstancePerLifetimeScope();
            builder.RegisterType<LanguageRepository>().As<ILanguageRepository>().InstancePerLifetimeScope();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerLifetimeScope();

            //core
            builder.RegisterType<MetaWeblog>().As<IMetaWeblog>().InstancePerLifetimeScope();

            return
                builder.Build();
        }
    }
}