using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public class BlogService : IBlogService {

        private static readonly string[] _emptyArray = new string[0];

        public BlogPost AddBlogPost(BlogPost blogPost) {

            return AddBlogPost(blogPost, _emptyArray);
        }

        public BlogPost AddBlogPost(BlogPost blogPost, string[] tags) {

            throw new NotImplementedException();
        }
    }
}