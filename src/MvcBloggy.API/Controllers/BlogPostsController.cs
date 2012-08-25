using MvcBloggy.API.Filters;
using MvcBloggy.API.Model.Dtos;
using MvcBloggy.API.Model.RequestModels;
using MvcBloggy.Domain.Entities;
using MvcBloggy.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostsController : ApiController {

        private readonly IEntityRepository<BlogPost> _blogPostRepository;
        private readonly IBlogService _blogService;

        public BlogPostsController(
            IEntityRepository<BlogPost> blogPostRepository,
            IBlogService blogService) {

            _blogPostRepository = blogPostRepository;
            _blogService = blogService;
        }

        public HttpResponseMessage GetBlogPosts(string lang, int page, int take) {
            
            if (page <= 0) { page = 1; }
            if (take <= 0) { take = 1; }

            if (string.IsNullOrEmpty(lang)) {

                ModelState.AddModelError("lang", "lang parameter cannot be null or empty");
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            var blogPosts = _blogService.GetBlogPosts(lang, page, take);

            return Request.CreateResponse(HttpStatusCode.OK, new PaginatedDto<BlogPostDto> {
                PageIndex = blogPosts.PageIndex,
                PageSize = blogPosts.PageSize,
                TotalCount = blogPosts.TotalCount,
                TotalPageCount = blogPosts.TotalPageCount,
                HasNextPage = blogPosts.HasNextPage,
                HasPreviousPage = blogPosts.HasPreviousPage,
                Dtos = blogPosts.Select(blogPost => new BlogPostDto(blogPost))
            });
        }

        //POST {"LanguageKey": 1, "Title": "Foo Bar Title", "Content": "Foo", "IsApproved": true, "CreatedOn": "8/23/2012 12:27:17 PM +03:00"}
        [InvalidModelStateFilter]
        public HttpResponseMessage PostBlogPost(BlogPostRequestModel blogPost) {

            var blogPostEntity = _blogService.AddBlogPost(
                blogPost.ToBlogPost(), blogPost.Tags);

            return Request.CreateResponse(
                HttpStatusCode.Created, new BlogPostDto(blogPostEntity));
        }
    }
}