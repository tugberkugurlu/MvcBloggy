using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.Web.Application.Http {

    public class BlogHttpClient : HttpClient, IBlogHttpClient {

        private const string _requestUri = "http://localhost:32729/api/";

        public BlogHttpClient() {
            
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(CommonConstants.ApplicationJsonMediaType));
        }

        public async Task<IEnumerable<BlogPostDto>> GetBlogPosts(int pageIndex, int take) {

            var requestUri = string.Format("{0}{1}?page={2}&take={3}", _requestUri, "blogposts", pageIndex, take);

            var response = await GetAsync(requestUri);
            response.EnsureSuccessStatusCode();
            var blogPosts = await response.Content.ReadAsAsync<IEnumerable<BlogPostDto>>();
            return blogPosts;
        }
    }
}