using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBloggy.Web.Infrastructure.Filters;

namespace MvcBloggy.Web.Areas.Admin.Controllers {

    [CustomAuthorize]
    public class DefaultController : Controller {

        public ActionResult Index() {

            return View();
        }
    }
}