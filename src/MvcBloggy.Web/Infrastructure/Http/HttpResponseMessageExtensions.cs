using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    internal static class HttpResponseMessageExtensions {

        internal static async Task<HttpApiResponseMessage<TEntity>> GetHttpApiResponseAsync<TEntity>(this HttpResponseMessage response) {

            if (response.IsSuccessStatusCode) {

                var content = await response.Content.ReadAsAsync<TEntity>();
                return new HttpApiResponseMessage<TEntity>(response, content);
            }

           return new HttpApiResponseMessage<TEntity>(response);
        }

        internal static async Task<HttpApiResponseMessage<TEntity>> GetHttpApiResponseAsync<TEntity>(this Task<HttpResponseMessage> responseTask) {
            
            var response = await responseTask;

            if (response.IsSuccessStatusCode) {

                var content = await response.Content.ReadAsAsync<TEntity>();
                return new HttpApiResponseMessage<TEntity>(response, content);
            }

            return new HttpApiResponseMessage<TEntity>(response);
        }

        internal static HttpApiResponseMessage GetHttpApiResponse(this HttpResponseMessage response) {

            return new HttpApiResponseMessage(response);
        }

        internal static async Task<HttpApiResponseMessage> GetHttpApiResponseAsync(this Task<HttpResponseMessage> responseTask) {

            var response = await responseTask;
            return new HttpApiResponseMessage(response);
        }
    }
}