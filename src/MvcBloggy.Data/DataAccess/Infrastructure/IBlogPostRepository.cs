using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.SqlServer;
using System.Linq.Expressions;
using GenericRepository;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    //Haven't found a way to mock the DbContext. So, I am skiping that part for now.
    //public interface IBlogPostRepository<C> : IRepository<BlogPost, C> where C : DbContext {

    public interface IBlogPostRepository : IRepository<BlogPost> {

        IEnumerable<BlogPost> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(string tag, ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(string[] tags, ApprovalStatus approvalStatus = ApprovalStatus.All);

        BlogPost GetSingle(int blogPostID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingle(Guid blogPostGUID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingle(string generatedLinkPart, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingleBySecondaryID(int secondaryID, ApprovalStatus approvalStatus = ApprovalStatus.All);
    }
}