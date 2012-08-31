using MvcBloggy.API.Infrastructure.Controllers;
using MvcBloggy.API.Model.Dtos;
using MvcBloggy.API.Model.RequestCommands;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostArchivesController : ApiController {

        private readonly IEntityRepository<BlogPost> _blogPostRepository;

        public BlogPostArchivesController(
            IEntityRepository<BlogPost> blogPostRepository) {

            _blogPostRepository = blogPostRepository;
        }

        public IEnumerable<MonthArchive> GetBlogPostMonthArchives() {

            return _blogPostRepository.GetMonthArchives();
        }

        [UriParameter("lang", "page", "take", "month", "year")]
        public PaginatedDto<BlogPostDto> GetBlogPostsByYearMonth(ArchiveYearMonthRequestCommand requestCmd) {

            return null;
        }
    }
}