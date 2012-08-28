using MvcBloggy.API.Model.Dtos;
using MvcBloggy.Web.Infrastructure.Http;
using MvcBloggy.Web.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class DefaultController : Controller {

        private const int pageSize = 10;
        private readonly IHttpApiClient<BlogPostDto, Guid> _httpClient;

        public DefaultController(IHttpApiClient<BlogPostDto, Guid> httpClient) {
            
            _httpClient = httpClient;
        }

        public async Task<ActionResult> Index(string language, int page = 1) {

            if (page <= 0) { page = 1; }

            var apiResponse = await _httpClient.GetPaginatedAsync(
                "blogposts", new { lang = language, page = page, take = pageSize });

            if (apiResponse.Response.IsSuccessStatusCode) {
                return View(apiResponse.Model);
            }

            throw new InvalidOperationException("Could connect to the HTTP API successfully");
        }
    }
}