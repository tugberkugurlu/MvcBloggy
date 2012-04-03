using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostCommentRepository : 
        Repository<MvcBloggyEntities, BlogPostComment>, IBlogPostCommentRepository {

        public override IQueryable<BlogPostComment> GetAll() {

            return GetAll(false).AsQueryable();
        }

        public IEnumerable<BlogPostComment> GetAll(bool includeUnapprovedEntries = false) {

            return includeUnapprovedEntries ? All : All.Where(x => x.IsApproved == true);
        }

        public IEnumerable<BlogPostComment> GetAll(int blogPostId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).Where(x => x.BlogPostID == blogPostId);
        }

        public BlogPostComment GetSingle(int blogPostCommentId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => x.BlogCommentID == blogPostCommentId);
        }
    }
}