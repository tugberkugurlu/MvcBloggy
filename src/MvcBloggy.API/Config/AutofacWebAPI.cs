using Autofac;
using Autofac.Integration.WebApi;
using MvcBloggy.API.Tracers;
using MvcBloggy.Domain.Entities;
using MvcBloggy.Domain.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Tracing;

namespace MvcBloggy.API.Config {

    public static class AutofacWebAPI {

        public static void Initialize(HttpConfiguration config) {

            config.DependencyResolver = new AutofacWebApiDependencyResolver(
                RegisterServices(new ContainerBuilder())
            );
        }

        private static IContainer RegisterServices(ContainerBuilder builder) {

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).PropertiesAutowired();

            //DbContext
            builder.RegisterType<MvcBloggyEntities>().As<DbContext>().InstancePerApiRequest();

            //Repositories
            builder.RegisterType<EntityRepository<BlogPostComment>>().As<IEntityRepository<BlogPostComment>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<BlogPost>>().As<IEntityRepository<BlogPost>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<BlogPostUrl>>().As<IEntityRepository<BlogPostUrl>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<BlogRoll>>().As<IEntityRepository<BlogRoll>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<DynamicPage>>().As<IEntityRepository<DynamicPage>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<Language>>().As<IEntityRepository<Language>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<RestrictedPageName>>().As<IEntityRepository<RestrictedPageName>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<Tag>>().As<IEntityRepository<Tag>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<TagsForBlogPost>>().As<IEntityRepository<TagsForBlogPost>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<TagsForDynamicPage>>().As<IEntityRepository<TagsForDynamicPage>>().InstancePerApiRequest();
            builder.RegisterType<EntityRepository<User>>().As<IEntityRepository<User>>().InstancePerApiRequest();

            //Services
            builder.RegisterType<CryptoService>().As<ICryptoService>().InstancePerApiRequest();
            builder.RegisterType<MembershipService>().As<IMembershipService>().InstancePerApiRequest();
            builder.RegisterType<BlogService>().As<IBlogService>().InstancePerApiRequest();

            //Web API Services
            builder.RegisterType<NLogTracer>().As<ITraceWriter>();

            return builder.Build();
        }
    }
}
