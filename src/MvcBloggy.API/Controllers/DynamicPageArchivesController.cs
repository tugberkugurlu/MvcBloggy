using GenericRepository.EntityFramework;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {

    public class DynamicPageArchivesController : ApiController {

        private readonly IEntityRepository<DynamicPage, Guid> _dynamicPageRepository;

        public DynamicPageArchivesController(
            IEntityRepository<DynamicPage, Guid> dynamicPageRepository) {

            _dynamicPageRepository = dynamicPageRepository;
        }

        public IEnumerable<MonthArchive> GetDynamicPageMonthArchives() {

            return _dynamicPageRepository.GetMonthArchives();
        }
    }
}