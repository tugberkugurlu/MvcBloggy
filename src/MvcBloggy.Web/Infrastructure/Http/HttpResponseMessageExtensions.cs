using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    internal static class HttpResponseMessageExtensions {

        internal static async Task<BlogHttpResponseMessage<TDto>> GetBlogHttpResponseAsync<TDto>(this HttpResponseMessage response) {

            try {

                //TODO: Handle the response here.
                //      Do not throw if the response is other than 200.
                //      Let the higher level decide that.
                //      Just don't try to deserialize the body.
                response.EnsureSuccessStatusCode();
                var content = await response.Content.ReadAsAsync<TDto>();
                return new BlogHttpResponseMessage<TDto>(response, content);
            }
            catch {

                return new BlogHttpResponseMessage<TDto>(response);
            }
        }
    }
}