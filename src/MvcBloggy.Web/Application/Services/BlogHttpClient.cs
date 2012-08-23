using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Application.Services {

    public class BlogHttpClient : HttpClient, IBlogHttpClient {

        private readonly string _requestUri;
        private readonly string _userName;
        private readonly string _password;

        public BlogHttpClient(IApplicationSettings appSettings) {

            _requestUri = appSettings.BlogApiBaseAddress;
            _userName = appSettings.BlogApiUserName;
            _password = appSettings.BlogApiPassword;

            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(CommonConstants.ApplicationJsonMediaType));
        }

        public async Task<PaginatedDto<BlogPostDto>> GetBlogPosts(string language, int pageIndex, int take) {

            var requestUri = string.Format("{0}{1}?lang={2}&page={3}&take={4}", 
                _requestUri, "blogposts", language, pageIndex, take);

            var response = await GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            var blogPosts = await response.Content.ReadAsAsync<PaginatedDto<BlogPostDto>>();
            return blogPosts;
        }
    }
}