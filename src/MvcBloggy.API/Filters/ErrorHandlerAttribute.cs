using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http.Filters;
using System.Net;
using System.Web.Http;

namespace MvcBloggy.API.Filters {
    
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class ErrorHandlerAttribute : ExceptionFilterAttribute {

        public override void OnException(HttpActionExecutedContext actionExecutedContext) {

            //TODO: Create a better error handler here
            //      Map certain errors to proper HTTP status codes
            var httpError = new HttpError(actionExecutedContext.Exception, false);
            actionExecutedContext.Response = 
                actionExecutedContext.Request.CreateErrorResponse(
                    HttpStatusCode.InternalServerError, httpError);
        }
    }
}