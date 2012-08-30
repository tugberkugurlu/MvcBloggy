using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.ModelBinding;
using MvcBloggy.API.Infrastructure.Controllers;
using System.ComponentModel.DataAnnotations;
using MvcBloggy.Domain.Entities;
using MvcBloggy.Domain.Services;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostTagsController : ApiController {

        private readonly IEntityRepository<BlogPost> _blogPostRepository;
        private readonly IEntityRepository<Tag> _tagRepository;
        private readonly IEntityRepository<TagsForBlogPost> _tagForBlogPostRepository;
        private readonly IBlogService _blogService;

        public BlogPostTagsController(
            IEntityRepository<BlogPost> blogPostRepository,
            IEntityRepository<Tag> tagRepository,
            IEntityRepository<TagsForBlogPost> tagForBlogPostRepository,
            IBlogService blogService) {

            _blogPostRepository = blogPostRepository;
            _tagRepository = tagRepository;
            _tagForBlogPostRepository = tagForBlogPostRepository;
            _blogService = blogService;
        }

        //GET /api/blogposts/tags/asp-net/asp-net-web-api
        public HttpResponseMessage Get(string[] tags) {

            var blogPosts = _blogPostRepository.GetAll()
                .Where(x => tags.All(t => x.TagsForBlogPosts.Any(y => y.Tag.TagName == t)));

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}