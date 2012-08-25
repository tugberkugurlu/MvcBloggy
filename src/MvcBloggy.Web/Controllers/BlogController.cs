using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class BlogController : Controller {

        public ActionResult Index() {

            return View();
        }
    }
}