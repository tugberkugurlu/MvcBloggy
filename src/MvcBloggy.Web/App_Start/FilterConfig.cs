using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBloggy.Web.Infrastructure.Mvc.Filters;

namespace MvcBloggy.Web {

    public class FilterConfig {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
            filters.Add(new RemoveWhitespacesAttribute());
        }
    }
}