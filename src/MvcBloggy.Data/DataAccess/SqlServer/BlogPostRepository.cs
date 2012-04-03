using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class BlogPostRepository : Repository<MvcBloggyEntities, BlogPost>, IBlogPostRepository {

        public override IQueryable<BlogPost> GetAll() {

            return GetAll(false).AsQueryable();
        }

        public IEnumerable<BlogPost> GetAll(bool includeUnapprovedEntries = false) {

            return includeUnapprovedEntries ? All : All.Where(x => x.IsApproved == true);
        }

        public IEnumerable<BlogPost> GetAll(int languageID, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).Where(x => x.LanguageID == languageID);
        }

        public IEnumerable<BlogPost> GetAll(string tag, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).ToList<BlogPost>().Where(x => 
                x.Tags.Any(t => t == tag)
            );
        }

        public IEnumerable<BlogPost> GetAll(string[] tags, bool includeUnapprovedEntries = false) {
        
            foreach (var tag in tags) {

                foreach (var blogPost in GetAll(includeUnapprovedEntries).ToList().Where(x => x.Tags.Any(t => t == tag))) {

                    yield return blogPost;
                }
            }
        }

        public BlogPost GetSingle(int blogPostID, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.BlogPostID == blogPostID
            );
        }

        public BlogPost GetSingle(Guid blogPostGUID, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.BlogPostGUID == blogPostGUID
            );
        }

        public BlogPost GetSingle(string generatedLinkPart, bool includeUnapprovedEntries = false) {

            throw new NotImplementedException();
        }

        public BlogPost GetSingleBySecondaryID(int secondaryID, bool includeUnapprovedEntries = false) {

            return GetAll(includeUnapprovedEntries).FirstOrDefault(x => 
                x.SecondaryID == secondaryID
            );
        }

    }
}