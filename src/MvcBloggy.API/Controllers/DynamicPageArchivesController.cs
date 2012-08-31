using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {

    public class DynamicPageArchivesController : ApiController {

        private readonly IEntityRepository<DynamicPage> _dynamicPageRepository;

        public DynamicPageArchivesController(
            IEntityRepository<DynamicPage> dynamicPageRepository) {

            _dynamicPageRepository = dynamicPageRepository;
        }

        public IEnumerable<MonthArchive> GetDynamicPageMonthArchives() {

            return _dynamicPageRepository.GetMonthArchives();
        }
    }
}
