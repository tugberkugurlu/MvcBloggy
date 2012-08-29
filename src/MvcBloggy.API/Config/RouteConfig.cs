using MvcBloggy.API.Infrastructure.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcBloggy.API.Config {
    
    public static class RouteConfig {

        public static void RegisterRoutes(HttpRouteCollection routes) {

            routes.MapHttpRoute(
                "BlogpostTagsHttpApiRoute",
                "api/blogposts/tags/{*tags}",
                new { controller = "blogposttags" }
            );

            routes.MapHttpRoute(
                "BlogpostCommentsHttpApiRoute",
                "api/blogposts/{blogpostkey}/comments",
                new { controller = "blogpostcomments" },
                new { blogpostkey = new GuidRouteConstraint() }
            );

            routes.MapHttpRoute(
                "DefaultHttpApiRoute",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional }
            );
        }
    }
}
