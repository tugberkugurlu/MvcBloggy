using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface ILanguageRepository : IRepository<Language> {

        IEnumerable<Language> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All);

        Language GetSingle(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        Language GetSingle(string languageCultureOne, ApprovalStatus approvalStatus = ApprovalStatus.All);
    }
}