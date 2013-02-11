using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {
    
    public static class BlogPostExtensions {

        public static PaginatedList<BlogPost> ToPaginatedBlogPostList(
            this IQueryable<BlogPost> blogPosts, int pageIndex, int pageSize) { 

            return blogPosts.OrderByDescending(x => x.CreatedOn)
                .ToPaginatedList(pageIndex, pageSize);
        }
    }
}