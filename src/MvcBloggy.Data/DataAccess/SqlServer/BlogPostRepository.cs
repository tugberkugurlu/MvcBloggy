using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostRepository : Repository<MvcBloggyContext, BlogPost>, IBlogPostRepository {

        public override IQueryable<BlogPost> GetAll() {

            return GetAll(false).AsQueryable();
        }

        public IEnumerable<BlogPost> GetAll(bool includeUnapprovedEntries = false) {

            return includeUnapprovedEntries ? All : All.Where(x => x.IsApproved == true);
        }

        public IEnumerable<BlogPost> GetAll(int languageId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).Where(x => x.LanguageId == languageId);
        }

        public IEnumerable<BlogPost> GetAll(string tag, bool includeUnapprovedEntries = false) {

            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll(string[] tags, bool includeUnapprovedEntries = false) {

            throw new NotImplementedException();
        }

        public BlogPost GetSingle(int blogPostId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.BlogPostId == blogPostId
            );
        }

        public BlogPost GetSingle(string generatedLinkPart, bool includeUnapprovedEntries = false) {

            throw new NotImplementedException();
        }

        public BlogPost GetSingleBySecondaryID(int secondaryId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.SecondaryID == secondaryId
            );
        }

    }
}