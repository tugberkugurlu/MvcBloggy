using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.ModelBinding;
using MvcBloggy.API.Infrastructure.Controllers;
using System.ComponentModel.DataAnnotations;

namespace MvcBloggy.API.Controllers {
    
    public class BlogPostTagsController : ApiController {

        //GET /api/blogposts/tags/asp-net/asp-net-web-api
        public HttpResponseMessage Get(string[] tags) {

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}