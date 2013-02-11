using MvcBloggy.API.Model.RequestCommands;
using MvcBloggy.Domain.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostTagsController : ApiController {

        private readonly IBlogService _blogService;

        public BlogPostTagsController(
            IBlogService blogService) {

            _blogService = blogService;
        }

        //GET /api/blogposts/tags/asp-net/asp-net-web-api
        public HttpResponseMessage GetBlogPosts(PaginatedRequestCommand requestCmd, string[] tags) {

            var blogPosts = _blogService.GetBlogPosts(
                requestCmd.Lang, requestCmd.Page, requestCmd.Take, tags);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}