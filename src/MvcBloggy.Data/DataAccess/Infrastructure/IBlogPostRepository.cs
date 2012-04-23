using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.SqlServer;
using System.Linq.Expressions;
using GenericRepository;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface IBlogPostRepository : IRepository<BlogPost> {

        IEnumerable<BlogPost> GetAll(string language);
        IEnumerable<BlogPost> GetAll(bool includeUnapprovedEntries = false);
        IEnumerable<BlogPost> GetAll(int languageId, bool includeUnapprovedEntries = false);
        IEnumerable<BlogPost> GetAll(string tag, bool includeUnapprovedEntries = false);
        IEnumerable<BlogPost> GetAll(string[] tags, bool includeUnapprovedEntries = false);

        BlogPost GetSingle(int blogPostId, bool includeUnapprovedEntries = false);
        BlogPost GetSingle(string generatedLinkPart, bool includeUnapprovedEntries = false);
        BlogPost GetSingleBySecondaryID(int secondaryId, bool includeUnapprovedEntries = false);
    }
}