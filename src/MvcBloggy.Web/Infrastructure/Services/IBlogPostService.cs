using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Web.Infrastructure.Services {
    
    public interface IBlogPostService {

        Task<PaginatedDto<BlogPostDto>> GetPostsAsync(string language);
        Task<PaginatedDto<BlogPostDto>> GetPostsAsync(string language, params string[] tags);
    }
}