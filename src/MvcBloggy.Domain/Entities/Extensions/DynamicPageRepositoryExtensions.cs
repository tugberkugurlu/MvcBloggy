using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {

    public static class DynamicPageRepositoryExtensions {

        public static IEnumerable<MonthArchive> GetMonthArchives(this IEntityRepository<DynamicPage> dynamicPageRepository) {

            return (from blogpost in dynamicPageRepository.GetAll()
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
