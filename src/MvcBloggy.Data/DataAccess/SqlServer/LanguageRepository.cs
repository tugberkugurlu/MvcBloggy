using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class LanguageRepository : Repository<MvcBloggyContext, Language>, ILanguageRepository {

        public override IQueryable<Language> GetAll() {

            return All.Where(x => x.IsApproved == true);
        }

        public IEnumerable<Language> GetAll(bool includeUnapprovedEntries = false) {

            return includeUnapprovedEntries ? All : GetAll();
        }

        public Language GetSingle(int languageId, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.LanguageId == languageId
            );
        }

        public Language GetSingle(string languageCultureOne, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.CultureOne == languageCultureOne
            );
        }
    }
}