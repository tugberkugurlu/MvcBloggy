using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface ILanguageRepository {

        IEnumerable<Language> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All);

        Language GetSingle(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All);
        Language GetSingle(string languageCultureOne, ApprovalStatus approvalStatus = ApprovalStatus.All);

        void Add(Language entity);
        void Delete(Language entity);
        void Edit(Language entity);
        void Save();
    }
}