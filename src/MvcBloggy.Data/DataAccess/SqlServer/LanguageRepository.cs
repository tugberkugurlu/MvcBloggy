using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class LanguageRepository : Repository<MvcBloggyEntities, Language>, ILanguageRepository {

        public override IQueryable<Language> GetAll() {

            return All.Where(x => x.IsApproved == true);
        }

        public IEnumerable<Language> GetAll(bool includeUnapprovedEntries = false) {

            return includeUnapprovedEntries ? All : GetAll();
        }

        public Language GetSingle(int languageID, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.LanguageID == languageID
            );
        }

        public Language GetSingle(string languageCultureOne, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.LanguageCultureOne == languageCultureOne
            );
        }
    }
}