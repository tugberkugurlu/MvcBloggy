using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBloggy.Web
{
    public class Filters {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
        }
    }
}