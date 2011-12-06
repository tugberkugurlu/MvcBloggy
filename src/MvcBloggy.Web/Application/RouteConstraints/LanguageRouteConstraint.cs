using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace MvcBloggy.Web.Application.RouteConstraints
{
    public class LanguageRouteConstraint : IRouteConstraint {

        private readonly string[] appLanguagesButDefault = Utility.AppLanguage.GetAllButDefault();

        public bool Match(HttpContextBase httpContext, Route route, string parameterName, RouteValueDictionary values, RouteDirection routeDirection) {

            return appLanguagesButDefault.Any(x => x == values[parameterName].ToString());
        }
    }
}