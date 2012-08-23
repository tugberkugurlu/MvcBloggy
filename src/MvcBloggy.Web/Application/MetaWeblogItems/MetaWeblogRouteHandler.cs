using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcBloggy.Web.Application.MetaWeblogItems {

    //https://bitbucket.org/FunnelWeb/dev/src/264a7c2272cc/src/FunnelWeb.Web/Application/MetaWeblog/MetaWeblogRouteHandler.cs
    public class MetaWeblogRouteHandler : IRouteHandler {

        public IHttpHandler GetHttpHandler(RequestContext requestContext) {

            return DependencyResolver.Current.GetService<IMetaWeblog>();
        }
    }
}