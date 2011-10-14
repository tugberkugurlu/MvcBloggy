using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface IBlogPostCommentRepository<C> : IRepository<BlogPostComment, C> where C : DbContext {

    }
}