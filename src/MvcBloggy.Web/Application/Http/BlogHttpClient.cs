using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Application.Http {

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

            var queryString = string.Empty;

            if (queryParameters != null) {
                queryString = new QueryStringCollection(queryParameters).ToString();
            }

            var requestUri = (string.IsNullOrEmpty(queryString))
                ? string.Format("{0}{1}", _requestUri, path)
                : string.Format("{0}{1}?{2}", _requestUri, path, queryString);

            var response = await GetAsync(requestUri);
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
    }
}