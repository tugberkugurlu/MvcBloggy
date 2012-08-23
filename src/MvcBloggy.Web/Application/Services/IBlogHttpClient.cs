using MvcBloggy.API.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Web.Application.Services {
    
    public interface IBlogHttpClient : IDisposable {

        Task<PaginatedDto<BlogPostDto>> GetBlogPosts(string language, int pageIndex, int take);
    }
}