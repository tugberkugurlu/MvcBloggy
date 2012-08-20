using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class DefaultController : Controller {

        public ViewResult Index(string language) {

            return View();
        }
    }
}