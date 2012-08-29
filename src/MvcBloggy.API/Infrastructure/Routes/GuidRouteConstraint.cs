using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace MvcBloggy.API.Infrastructure.Routes {

    public class GuidRouteConstraint : IHttpRouteConstraint {

        public bool Match(
            HttpRequestMessage request, 
            IHttpRoute route, 
            string parameterName, 
            IDictionary<string, object> values, 
            HttpRouteDirection routeDirection) {

            var value = values[parameterName].ToString();
            
            Guid guidValue;
            var result = Guid.TryParseExact(value, "D", out guidValue);

            return result;
        }
    }
}