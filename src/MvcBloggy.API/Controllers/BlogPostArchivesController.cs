using GenericRepository.EntityFramework;
using MvcBloggy.API.Model.Dtos;
using MvcBloggy.API.Model.RequestCommands;
using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostArchivesController : ApiController {

        private readonly IEntityRepository<BlogPost, Guid> _blogPostRepository;

        public BlogPostArchivesController(
            IEntityRepository<BlogPost, Guid> blogPostRepository) {

            _blogPostRepository = blogPostRepository;
        }

        public IEnumerable<MonthArchive> GetBlogPostMonthArchives() {

            return _blogPostRepository.GetMonthArchives();
        }

        public PaginatedDto<BlogPostDto> GetBlogPostsByYearMonth(
            ArchiveYearMonthRequestCommand requestCmd) {

            return null;
        }
    }
}