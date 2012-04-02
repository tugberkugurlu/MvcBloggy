using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class LanguageRepository : GenericRepository<MvcBloggyEntities, Language>, ILanguageRepository {

        public IEnumerable<Language> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All) {

            IEnumerable<Language> query = Context.Languages.OrderBy(x => x.LanguageOrder);

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

        public Language GetSingle(int languageID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).FirstOrDefault(x => x.LanguageID == languageID);
            return query;
        }

        public Language GetSingle(string languageCultureOne, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).FirstOrDefault(x => x.LanguageCultureOne == languageCultureOne);
            return query;
        }
    }
}