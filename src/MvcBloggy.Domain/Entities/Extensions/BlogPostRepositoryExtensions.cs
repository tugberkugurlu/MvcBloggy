using GenericRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MvcBloggy.Domain.Entities {
    
    public static class BlogPostRepositoryExtensions {

        public static IQueryable<BlogPost> GetAllByLang(this IEntityRepository<BlogPost, Guid> blogPostRepository, string lang) {

            var query = blogPostRepository.GetAllIncluding(x => x.Language)
                .Where(x => x.Language.CultureOne == lang);

            return query;
        }

        //ref: http://stackoverflow.com/questions/9886190/entity-framework-efficiently-grouping-by-month
        public static IEnumerable<MonthArchive> GetMonthArchives(this IEntityRepository<BlogPost, Guid> blogPostRepository) {

            return (from blogpost in blogPostRepository.GetAll()
                    where blogpost.IsApproved == true
                    group blogpost by new {
                        Year = blogpost.CreatedOn.Year,
                        Month = blogpost.CreatedOn.Month
                    } into g
                    select new MonthArchive {
                        Year = g.Key.Year,
                        Month = g.Key.Month,
                        Total = g.Sum(x => 1)
                    }
            ).AsEnumerable();
        }
    }
}