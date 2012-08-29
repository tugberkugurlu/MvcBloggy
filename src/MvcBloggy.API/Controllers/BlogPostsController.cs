using MvcBloggy.API.Filters;
using MvcBloggy.API.Model;
using MvcBloggy.API.Model.Dtos;
using MvcBloggy.API.Model.RequestCommands;
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

        //GET /api/blogposts?take=10&page=1&lang=en
        public HttpResponseMessage GetBlogPosts([FromUri]PaginatedRequestCommand requestCmd) {

            var blogPosts = _blogService.GetBlogPosts(requestCmd.Lang, requestCmd.Page, requestCmd.Take);

            return Request.CreateResponse(HttpStatusCode.OK, new PaginatedDto<BlogPostDto> {
                PageIndex = blogPosts.PageIndex,
                PageSize = blogPosts.PageSize,
                TotalCount = blogPosts.TotalCount,
                TotalPageCount = blogPosts.TotalPageCount,
                HasNextPage = blogPosts.HasNextPage,
                HasPreviousPage = blogPosts.HasPreviousPage,
                Items = blogPosts.Select(blogPost => blogPost.ToBlogPostDto())
            });
        }

        //POST /api/blogposts
        //{"LanguageKey": 1, "Title": "Foo Bar Title", "Content": "Foo", "IsApproved": true, "CreatedOn": "8/23/2012 12:27:17 PM +03:00"}
        public HttpResponseMessage PostBlogPost(BlogPostRequestModel blogPost) {

            var blogPostEntity = _blogService.AddBlogPost(blogPost.ToBlogPost(), blogPost.Tags);
            return Request.CreateResponse(HttpStatusCode.Created, blogPostEntity.ToBlogPostDto());
        }
    }
}