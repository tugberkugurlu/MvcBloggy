using GenericRepository;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {
    
    public interface IBlogService {

        PaginatedList<BlogPost> GetBlogPosts(string lang, int pageIndex, int pageSize);

        BlogPost AddBlogPost(BlogPost blogPost);
        BlogPost AddBlogPost(BlogPost blogPost, string[] tags);
    }
}