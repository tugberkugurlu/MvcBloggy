using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostRepository : GenericRepository<MvcBloggyEntities, BlogPost>, IBlogPostRepository {

        public IEnumerable<BlogPost> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All) {

            IEnumerable<BlogPost> query = Context.BlogPosts;

            switch (approvalStatus) {

                case ApprovalStatus.Approved:
                    query = query.Where(x => x.IsApproved == true);
                    break;

                case ApprovalStatus.NotApproved:
                    query = query.Where(x => x.IsApproved == false);
                    break;
            }

            return query;
        }

        public IEnumerable<BlogPost> GetAll(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).Where(x => x.LanguageID == languageID);
            return query;
        }

        public IEnumerable<BlogPost> GetAll(string tag, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).
                ToList<BlogPost>().Where(x => 
                    x.Tags.Where(y => y == tag).Count() >= 1
                );

            return query;
        }

        public IEnumerable<BlogPost> GetAll(string[] tags, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).
                ToList<BlogPost>();

            foreach (var tag in tags) {

                query = query.Where(x =>
                    x.Tags.Where(y => y == tag).Count() >= 1
                ).ToList();

                if (query.Count <= 0)
                    break;
            }

            return query;
        }

        public BlogPost GetSingle(int blogPostID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).
                FirstOrDefault(x => x.BlogPostID == blogPostID);

            return query;
        }

        public BlogPost GetSingle(Guid blogPostGUID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).
                FirstOrDefault(x => x.BlogPostGUID == blogPostGUID);

            return query;
        }

        public BlogPost GetSingle(string generatedLinkPart, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            throw new NotImplementedException();
        }

        public BlogPost GetSingleBySecondaryID(int secondaryID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).FirstOrDefault(x => x.SecondaryID == secondaryID);
            return query;
        }

        public IQueryable<BlogPost> FindBy(System.Linq.Expressions.Expression<Func<BlogPost, bool>> predicate) {

            throw new NotImplementedException();
        }

    }
}