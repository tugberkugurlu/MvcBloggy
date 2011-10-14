using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostRepository : 
        Repository<BlogPost, MvcBloggyEntities>, IBlogPostRepository<MvcBloggyEntities> {

        private readonly MvcBloggyEntities _entities;

        public BlogPostRepository() {
            
            _entities = this.Context;
        }

    }
}