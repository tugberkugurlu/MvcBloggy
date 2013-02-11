using GenericRepository;
using GenericRepository.EntityFramework;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public class BlogService : IBlogService {

        private static readonly string[] _emptyArray = new string[0];
        private readonly IEntityRepository<BlogPost, Guid> _blogPostRepository;

        public BlogService(IEntityRepository<BlogPost, Guid> blogPostRepository) {

            _blogPostRepository = blogPostRepository;
        }

        public PaginatedList<BlogPost> GetBlogPosts(string lang, int pageIndex, int pageSize) {

            PaginatedList<BlogPost> blogPosts = _blogPostRepository.GetAllByLang(lang)
                .ToPaginatedBlogPostList(pageIndex, pageSize);

            return blogPosts;
        }

        public PaginatedList<BlogPost> GetBlogPosts(string lang, int pageIndex, int pageSize, string[] tags) {

            PaginatedList<BlogPost> blogPosts = _blogPostRepository.GetAllByLang(lang)
                .Where(x => tags.All(t => x.TagsForBlogPosts.Any(y => y.Tag.TagName == t)))
                .ToPaginatedBlogPostList(pageIndex, pageSize);

            return blogPosts;
        }

        public BlogPost AddBlogPost(BlogPost blogPost) {

            return AddBlogPost(blogPost, _emptyArray);
        }

        public BlogPost AddBlogPost(BlogPost blogPost, string[] tags) {

            throw new NotImplementedException();
        }
    }
}