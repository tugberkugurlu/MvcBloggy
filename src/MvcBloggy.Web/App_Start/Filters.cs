using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBloggy.Web.Application.Filters;

namespace MvcBloggy.Web
{
    public class Filters {

        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {

            filters.Add(new HandleErrorAttribute());
            filters.Add(new RemoveWhitespacesAttribute());
        }
    }
}