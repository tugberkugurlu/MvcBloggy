using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {
    
    public class BlogPostRepositoryExtensions {

        //ref: http://stackoverflow.com/questions/9886190/entity-framework-efficiently-grouping-by-month
        public static IEnumerable<MonthArchive> GetMonthArchives(this IEntityRepository<BlogPost> blogPostRepository) {

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