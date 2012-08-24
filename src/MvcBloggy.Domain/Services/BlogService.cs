using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public class BlogService : IBlogService {

        private static readonly string[] _emptyArray = new string[0];
        private readonly IEntityRepository<BlogPost> _blogPostRepository;

        public BlogService(IEntityRepository<BlogPost> blogPostRepository) {

            _blogPostRepository = blogPostRepository;
        }

        public PaginatedList<BlogPost> GetBlogPosts(string lang, int pageIndex, int pageSize) {

            return _blogPostRepository.AllIncluding(x => x.Language)
                .Where(x => x.Language.CultureOne == lang)
                .OrderByDescending(x => x.CreatedOn)
                .ToPaginatedList(pageIndex, pageSize);
        }

        public BlogPost AddBlogPost(BlogPost blogPost) {

            return AddBlogPost(blogPost, _emptyArray);
        }

        public BlogPost AddBlogPost(BlogPost blogPost, string[] tags) {

            throw new NotImplementedException();
        }
    }
}