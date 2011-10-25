using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.SqlServer;
using System.Linq.Expressions;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    //Haven't found a way to mock the DbContext. So, I am skiping that part for now.
    //public interface IBlogPostRepository<C> : IRepository<BlogPost, C> where C : DbContext {

    public interface IBlogPostRepository {

        IEnumerable<BlogPost> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(string tag, ApprovalStatus approvalStatus = ApprovalStatus.All);
        IEnumerable<BlogPost> GetAll(string[] tags, ApprovalStatus approvalStatus = ApprovalStatus.All);
        
        //Not sure if this needs to be implemented or not...
        //IEnumerable<BlogPost> FindBy(Expression<Func<BlogPost, bool>> predicate);

        BlogPost GetSingle(int blogPostID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingle(Guid blogPostGUID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingle(string generatedLinkPart, ApprovalStatus approvalStatus = ApprovalStatus.All);
        BlogPost GetSingleBySecondaryID(int secondaryID, ApprovalStatus approvalStatus = ApprovalStatus.All);

        void Add(BlogPost entity);
        void Delete(BlogPost entity);
        void Edit(BlogPost entity);
        void Save();
    }
}