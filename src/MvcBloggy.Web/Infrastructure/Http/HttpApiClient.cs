using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web;
using MvcBloggy.API.Model.Dtos;
using System.Collections;
using System.Net.Http.Headers;

namespace MvcBloggy.Web.Infrastructure.Http {

    public abstract class HttpApiClient<TEntity, TKey> : HttpClient, IHttpApiClient<TEntity, TKey> where TEntity : IDto where TKey : struct {

        public HttpApiClient() {

            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(CommonConstants.ApplicationJsonMediaType));
        }

        public virtual async Task<HttpApiResponseMessage<PaginatedDto<TEntity>>> GetPaginatedAsync(string path, object queryParameters) {

            return await GetAsync(BuildRequestUri(path, queryParameters)).GetHttpApiResponseAsync<PaginatedDto<TEntity>>();
        }

        public virtual Task<HttpApiResponseMessage<TEntity>> GetSingleAsync(string path, TKey key) {

            return GetSingleAsync(path, key, null);
        }

        public virtual async Task<HttpApiResponseMessage<TEntity>> GetSingleAsync(string path, TKey key, object queryParameters) {

            return await GetAsync(BuildRequestUri(path, key, queryParameters)).GetHttpApiResponseAsync<TEntity>();
        }

        public virtual Task<HttpApiResponseMessage<TEntity>> PostAsync<TRequestModel>(string path, TRequestModel requestModel) {

            return PostAsync(path, requestModel, null);
        }

        public virtual async Task<HttpApiResponseMessage<TEntity>> PostAsync<TRequestModel>(string path, TRequestModel requestModel, object queryParameters) {

            return await this.PostAsJsonAsync<TRequestModel>(BuildRequestUri(path, queryParameters), requestModel).GetHttpApiResponseAsync<TEntity>();
        }

        public virtual Task<HttpApiResponseMessage<TEntity>> PutAsync<TRequestModel>(string path, TKey key, TRequestModel requestModel) {

            return PutAsync(path, key, requestModel, null);
        }

        public virtual async Task<HttpApiResponseMessage<TEntity>> PutAsync<TRequestModel>(string path, TKey key, TRequestModel requestModel, object queryParameters) {

            return await this.PutAsJsonAsync<TRequestModel>(BuildRequestUri(path, queryParameters), requestModel).GetHttpApiResponseAsync<TEntity>();
        }

        public virtual Task<HttpApiResponseMessage> DeleteAsync(string path, TKey key) {

            return DeleteAsync(path, key, null);
        }

        public virtual async Task<HttpApiResponseMessage> DeleteAsync(string path, TKey key, object queryParameters) {

            return await DeleteAsync(BuildRequestUri(path, key, queryParameters)).GetHttpApiResponseAsync();
        }

        private string BuildRequestUri(string path, object queryParameters = null) {

            return BuildRequestUri(path, default(TKey), queryParameters);
        }

        private string BuildRequestUri(string path, TKey key, object queryParameters = null) {

            var queryString = string.Empty;
            var baseRequestUri = BaseAddress.ToString();

            if (queryParameters != null)
                queryString = new QueryStringCollection(queryParameters).ToString();

            var requestUri = string.Format("{0}{1}", baseRequestUri, path);
            
            if (!key.Equals(default(TKey)))
                requestUri = string.Format("{0}/{1}", requestUri, key.ToString());

            if (!string.IsNullOrEmpty(queryString))
                requestUri = string.Format("{0}?{1}", requestUri, queryString);

            return requestUri;
        }
    }
}