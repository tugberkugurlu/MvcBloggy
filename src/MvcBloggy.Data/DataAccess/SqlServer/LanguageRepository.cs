using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class LanguageRepository : ILanguageRepository {

        private readonly MvcBloggyEntities _entities = new MvcBloggyEntities();

        public IEnumerable<Language> GetAll(ApprovalStatus approvalStatus = ApprovalStatus.All) {

            IEnumerable<Language> query = _entities.Languages.OrderBy(x => x.LanguageOrder);

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

        public Language GetSingle(Guid languageGUID, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).FirstOrDefault(x => x.LanguageGUID == languageGUID);
            return query;
        }

        public Language GetSingle(string languageCultureOne, ApprovalStatus approvalStatus = ApprovalStatus.All) {

            var query = this.GetAll(approvalStatus).FirstOrDefault(x => x.LanguageCultureOne == languageCultureOne);
            return query;
        }

        public void Add(Language entity) {

            _entities.Languages.Add(entity);
        }

        public void Delete(Language entity) {

            _entities.Languages.Remove(entity);
        }

        public void Edit(Language entity) {

            _entities.Entry<Language>(entity).State = System.Data.EntityState.Modified;
        }

        public void Save() {

            _entities.SaveChanges();
        }
    }
}