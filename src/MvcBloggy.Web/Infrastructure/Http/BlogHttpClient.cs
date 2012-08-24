using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Http {

    public class BlogHttpClient<T> : HttpClient, IBlogHttpClient<T> {

        private readonly string _requestUri;
        private readonly string _userName;
        private readonly string _password;

        public BlogHttpClient(IApplicationSettings appSettings) {

            _requestUri = appSettings.BlogApiBaseAddress;
            _userName = appSettings.BlogApiUserName;
            _password = appSettings.BlogApiPassword;

            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(CommonConstants.ApplicationJsonMediaType));
        }

        public async Task<PaginatedDto<T>> GetPaginatedAsync(string path, object queryParameters) {

            var response = await GetAsync(BuildRequestUri(path, queryParameters));
            response.EnsureSuccessStatusCode();
            var blogPosts = await response.Content.ReadAsAsync<PaginatedDto<T>>();
            return blogPosts;
        }

        public Task<BlogHttpResponseMessage<T>> GetSingleAsync(string path, Guid key) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage<T>> GetSingleAsync(string path, Guid key, object queryParameters) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage<T>> PostAsync<TEntity>(string path, TEntity requestModel) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage<T>> PostAsync<TEntity>(string path, TEntity requestModel, object queryParameters) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage<T>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage<T>> PutAsync<TEntity>(string path, Guid key, TEntity requestModel, object queryParameters) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key) {
            throw new NotImplementedException();
        }

        public Task<BlogHttpResponseMessage> DeleteAsync(string path, Guid key, object queryParameters) {
            throw new NotImplementedException();
        }

        private string BuildRequestUri(string path, object queryParameters = null) {

            return BuildRequestUri(path, default(Guid), queryParameters);
        }

        private string BuildRequestUri(string path, Guid key = default(Guid), object queryParameters = null) {

            var queryString = string.Empty;

            if (queryParameters != null) {
                queryString = new QueryStringCollection(queryParameters).ToString();
            }

            var requestUri = string.Format("{0}{1}", _requestUri, path);

            if(key != default(Guid))
                requestUri = string.Format("{0}/{1}", requestUri, key.ToString());

            if(!string.IsNullOrEmpty(queryString)) 
                requestUri = string.Format("{0}?{1}", requestUri, queryString);

            return requestUri;
        }
    }
}