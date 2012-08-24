using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Infrastructure.Mvc {

    public class LocalizedControllerFactory : DefaultControllerFactory {

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType) {

            var lang = (string)requestContext.RouteData.Values["language"];
            if (!string.IsNullOrEmpty(lang))
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(lang);

            return base.GetControllerInstance(requestContext, controllerType);
        }

    }
}