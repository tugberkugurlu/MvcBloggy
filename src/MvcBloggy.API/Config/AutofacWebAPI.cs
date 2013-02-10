using Autofac;
using Autofac.Integration.WebApi;
using GenericRepository.EntityFramework;
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
            builder.RegisterGeneric(typeof(EntityRepository<>))
                       .As(typeof(IEntityRepository<>))
                       .InstancePerApiRequest();

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
