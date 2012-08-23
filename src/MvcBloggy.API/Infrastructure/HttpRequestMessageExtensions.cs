using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.API {
    
    public static class HttpRequestMessageExtensions {

        public static string GetClientIp(this HttpRequestMessage request) {

            return ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
        }
    }
}