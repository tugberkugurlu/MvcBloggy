using MvcBloggy.Web.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web.Controllers {

    public class MetaWeblogController : BaseController {

        public ActionResult WlwManifest() {

            Stream resourceStream = typeof(MetaWeblogController).Assembly.
                GetManifestResourceStream("MvcBloggy.Web.Infrastructure.MetaWeblogItems.wlwmanifest.xml");

            using (var resourceStreamReader = new StreamReader(resourceStream)) {
                string contents = resourceStreamReader.ReadToEnd();
                return Content(contents, "application/wlwmanifest+xml");
            }
        }
    }
}