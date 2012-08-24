using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Infrastructure.Mvc.Filters {

    public class CustomAuthorizeAttribute : AuthorizeAttribute {

        public override void OnAuthorization(AuthorizationContext filterContext) {

            //TODO: have a look: http://stackoverflow.com/questions/6016892/asp-net-mvc-3-applying-authorizeattribute-to-areas

            var authRequired = !filterContext.ActionDescriptor.IsDefined(typeof(BypassAuthorizationAttribute), true) ||
                filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(BypassAuthorizationAttribute), true);

            if (authRequired && !filterContext.RequestContext.HttpContext.Request.IsLocal)
                base.OnAuthorization(filterContext);
        }
    }
}