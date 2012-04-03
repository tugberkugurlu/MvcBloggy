using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Tests.Fakes {

    internal class FakeBlogPostRepository : FakeRepository<BlogPost>, IBlogPostRepository {

        public IEnumerable<BlogPost> GetAll(bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll(int languageID, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll(string tag, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public IEnumerable<BlogPost> GetAll(string[] tags, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public BlogPost GetSingle(int blogPostID, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public BlogPost GetSingle(Guid blogPostGUID, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public BlogPost GetSingle(string generatedLinkPart, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }

        public BlogPost GetSingleBySecondaryID(int secondaryID, bool includeUnapprovedEntries = false) {
            throw new NotImplementedException();
        }
    }
}
