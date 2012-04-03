using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using GenericRepository;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface IBlogPostCommentRepository : IRepository<BlogPostComment> {

        IEnumerable<BlogPostComment> GetAll(bool includeUnapprovedEntries = false);
        IEnumerable<BlogPostComment> GetAll(int blogPostId, bool includeUnapprovedEntries = false);

        BlogPostComment GetSingle(int blogPostCommentId, bool includeUnapprovedEntries = false);
    }
}