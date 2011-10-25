using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostCommentRepository : IBlogPostCommentRepository {

        private readonly MvcBloggyEntities _entities = new MvcBloggyEntities();

    }
}
