using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MvcBloggy.API.Client.Services {

    public class BlogPostService : IBlogPostService {

        public Task<Model.Dtos.PaginatedDto<BlogPostDto>> GetPostsAsync(string language) {

            throw new NotImplementedException();
        }

        public Task<PaginatedDto<BlogPostDto>> GetPostsAsync(string language, params string[] tags) {

            throw new NotImplementedException();
        }
    }
}