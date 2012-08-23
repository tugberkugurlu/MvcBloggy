using MvcBloggy.Web.Application.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class DefaultController : Controller {

        private const int pageSize = 10;

        public async Task<ActionResult> Index(string language, int page = 1) {

            if (page <= 0) {
                page = 1;
            }

            using (BlogHttpClient httpClient = new BlogHttpClient()) {

                var blogPosts = await httpClient.GetBlogPosts(page, pageSize);
                return View(blogPosts);
            }
        }
    }
}