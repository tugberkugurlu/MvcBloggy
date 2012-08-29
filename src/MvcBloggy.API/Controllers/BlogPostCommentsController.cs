using MvcBloggy.API.Model.RequestCommands;
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
    
    public class BlogPostCommentsController : ApiController {

        private readonly IEntityRepository<BlogPost> _blogPostRepository;
        private readonly IEntityRepository<BlogPostComment> _blogPostCommentRepository;
        private readonly IBlogService _blogService;

        public BlogPostCommentsController(
            IEntityRepository<BlogPost> blogPostRepository,
            IEntityRepository<BlogPostComment> blogPostCommentRepository,
            IBlogService blogService) {

            _blogPostRepository = blogPostRepository;
            _blogPostCommentRepository = blogPostCommentRepository;
            _blogService = blogService;
        }

        //GET /api/blogposts/a063e488-3125-4999-a317-1943cecfd591/comments?lang=en&page=2&take=10
        public HttpResponseMessage GetComments(Guid blogPostKey, [FromUri]PaginatedRequestCommand requestCmd) {

            //TODO: Implement the real logic here

            return Request.CreateResponse(HttpStatusCode.OK, new { key = blogPostKey, command = requestCmd });
        }
    }
}