using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface ILanguageRepository : IRepository<Language> {

        IEnumerable<Language> GetAll(bool includeUnapprovedEntries = false);

        Language GetSingle(int languageID, bool includeUnapprovedEntries = false);
        Language GetSingle(string languageCultureOne, bool includeUnapprovedEntries = false);
    }
}