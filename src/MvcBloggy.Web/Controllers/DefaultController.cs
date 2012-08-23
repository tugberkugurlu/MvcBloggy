using MvcBloggy.Web.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class DefaultController : Controller {

        private const int pageSize = 10;
        private readonly IBlogHttpClient _httpClient;

        public DefaultController(IBlogHttpClient httpClient) {

            _httpClient = httpClient;
        }

        public async Task<ActionResult> Index(string language, int page = 1) {

            if (page <= 0) { page = 1; }

            var blogPosts = await _httpClient.GetBlogPosts(language, page, pageSize);
            return View(blogPosts);
        }
    }
}