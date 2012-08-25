using MvcBloggy.API.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using Xunit;

namespace MvcBloggy.API.Test.Filters {

    public class InvalidModelStateFilterAttributeTest {

        [Fact]
        public void InvalidModelStateFilterAttribute_ShouldSetThe400ResponseIfTheModelStateIsNotValid() { 

            //Arange
            var invalidModelStateFilter = new InvalidModelStateFilterAttribute();
            var request = new HttpRequestMessage();
            var actionContext = ContextUtil.GetHttpActionContext(request);
            actionContext.ModelState.AddModelError("foo", "foo is invalid.");

            //Act
            invalidModelStateFilter.OnActionExecuting(actionContext);

            //Assert
            Assert.NotNull(actionContext.Response);
            Assert.Equal(actionContext.Response.StatusCode, HttpStatusCode.BadRequest);
        }

        [Fact]
        public void InvalidModelStateFilterAttribute_ShouldNotSetTheResponseIfTheModelStateIsValid() {

            //Arange
            var invalidModelStateFilter = new InvalidModelStateFilterAttribute();
            var request = new HttpRequestMessage();
            var actionContext = ContextUtil.GetHttpActionContext(request);

            //Act
            invalidModelStateFilter.OnActionExecuting(actionContext);

            //Assert
            Assert.Null(actionContext.Response);
        }

        [Fact]
        public void InvalidModelStateFilterAttribute_ShouldReturnTheResponseWithProperContentTypeIfTheModelStateIsNotValid() {

            //NOTE: This test might seems that we are here testing the framework
            //      stuff but we are not. We just make sure here that InvalidModelStateFilterAttribute
            //      really honors the conneg.

            //Arange
            var invalidModelStateFilter = new InvalidModelStateFilterAttribute();
            var request = new HttpRequestMessage();
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var actionContext = ContextUtil.GetHttpActionContext(request);
            actionContext.ModelState.AddModelError("foo", "foo is invalid.");

            //NOTE: Here, the response is being returned through the CreateErrorResponse extension
            //      method of the HttpRequestMessage object. What this basically does is
            //      to pass an HttpError instance to another extension method, CreateResponse<T>.
            //      The CreateResponse<T> method looks at the configuration instance 
            //      (yes, config shouldn't be null) and gets the IContentNegotiator service 
            //      through Services. If we create a HttpConfiguration object with its
            //      parameterless ctor, the negotiator will be the type of DefaultContentNegotiator.
            //      DefaultContentNegotiator should negotiate properly here.

            //Act
            invalidModelStateFilter.OnActionExecuting(actionContext);

            //Assert
            Assert.NotNull(actionContext.Response);
            Assert.True(actionContext.Response.Content.Headers.ContentType.MediaType.Equals("application/json", StringComparison.OrdinalIgnoreCase));
        }

        [Fact]
        public Task InvalidModelStateFilterAttribute_ShouldReturnTheModelStateErrorsIfTheModelStateIsNotValid() {

            //Arange
            var invalidModelStateFilter = new InvalidModelStateFilterAttribute();
            var request = new HttpRequestMessage();
            var actionContext = ContextUtil.GetHttpActionContext(request);
            actionContext.ModelState.AddModelError("foo", "foo is invalid.");

            //Act
            invalidModelStateFilter.OnActionExecuting(actionContext);
            return actionContext.Response.Content.ReadAsAsync<HttpError>()

                //Assert
                .ContinueWith(task => {

                    var httpError = task.Result;

                    Assert.NotNull(actionContext.Response);
                    Assert.True(httpError.Keys.Any(key => key.Equals("ModelState", StringComparison.OrdinalIgnoreCase)));
                    Assert.IsType<HttpError>(httpError["ModelState"]);
                    Assert.True(((HttpError)httpError["ModelState"]).Keys.Any(x => x.Equals("foo", StringComparison.OrdinalIgnoreCase)));
                });
        }
    }
}