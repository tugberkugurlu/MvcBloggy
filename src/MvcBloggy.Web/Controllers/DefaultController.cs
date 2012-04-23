using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Web.Controllers {

    public class DefaultController : Controller {

        private readonly IBlogPostRepository _blogPostRepo;

        public DefaultController(IBlogPostRepository blogPostRepo) {

            _blogPostRepo = blogPostRepo;
        }

        public ViewResult Index(string language) {

            var posts = _blogPostRepo.GetAll(language).ToList();

            return View(posts);
        }
    }
}