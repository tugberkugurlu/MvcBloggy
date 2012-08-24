using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Areas.Admin.Controllers {

    public class AuthController : Controller {

        public ViewResult LogOn() {

            return View();
        }
    }
}