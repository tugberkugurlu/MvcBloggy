using MvcBloggy.API.Routes;
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
                "BlogpostHttpApiRoute",
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
