﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17020
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcBloggy.Web.Areas.Admin.Views.Shared
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/_Layout.cshtml")]
    public class _Layout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Layout()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <meta name=\"viewport\" content=\"width=devic" +
"e-width\" />\r\n    <title>");


            
            #line 6 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <link href=\"");


            
            #line 7 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(Url.Content("~/Content/v2/css/admin/bootstrap.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n    <link href=\"");


            
            #line 8 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(Url.Content("~/Content/v2/css/admin/mvcbloggy.admin.css"));

            
            #line default
            #line hidden
WriteLiteral("\" rel=\"stylesheet\" type=\"text/css\" />\r\n</head>\r\n<body>\r\n\r\n    <div class=\"topbar\"" +
">\r\n      <div class=\"topbar-inner\">\r\n        <div class=\"container-fluid\">\r\n    " +
"      <a class=\"brand\" href=\"");


            
            #line 15 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                            Write(Url.Action("index", new { controller = "default" }));

            
            #line default
            #line hidden
WriteLiteral("\">MvcBloggy Admin Panel</a>\r\n          <ul class=\"nav\">\r\n            <li class=\"a" +
"ctive\"><a href=\"");


            
            #line 17 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                                   Write(Url.Action("index", new { controller = "post" }));

            
            #line default
            #line hidden
WriteLiteral("\">Posts</a></li>\r\n            <li><a href=\"");


            
            #line 18 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                    Write(Url.Action("index", new { controller = "page" }));

            
            #line default
            #line hidden
WriteLiteral("\">Dynamic Pages</a></li>\r\n            <li><a href=\"");


            
            #line 19 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                    Write(Url.Action("index", new { controller = "blogroll" }));

            
            #line default
            #line hidden
WriteLiteral("\">Blog Roll</a></li>\r\n            <li><a href=\"");


            
            #line 20 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                    Write(Url.Action("index", new { controller = "comment" }));

            
            #line default
            #line hidden
WriteLiteral("\">Comments</a></li>\r\n            <li><a href=\"");


            
            #line 21 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                    Write(Url.Action("index", new { controller = "contact" }));

            
            #line default
            #line hidden
WriteLiteral("\">Comments</a></li>\r\n            <li><a href=\"");


            
            #line 22 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                    Write(Url.Action("index", new { controller = "setting" }));

            
            #line default
            #line hidden
WriteLiteral(@""">General Settings</a></li>
          </ul>
          <p class=""pull-right"">Logged in as <a href=""#"">username</a></p>
        </div>
      </div>
    </div>

    <div class=""container-fluid"">

      <div class=""sidebar"">
        <div class=""well"">
          <h5>Sidebar</h5>
          <ul>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
          </ul>
          <h5>Sidebar</h5>
          <ul>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
          </ul>
          <h5>Sidebar</h5>
          <ul>
            <li><a href=""#"">Link</a></li>
            <li><a href=""#"">Link</a></li>
          </ul>
        </div>
      </div>

      <div class=""content"">

        ");


            
            #line 59 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n        <footer>\r\n            <p>&copy; Tugberk Ugurlu ");


            
            #line 62 "..\..\Areas\Admin\Views\Shared\_Layout.cshtml"
                                Write(DateTime.Today.Year);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n        </footer>\r\n\r\n       </div>\r\n\r\n    </div>\r\n</body>\r\n</html>");


        }
    }
}
#pragma warning restore 1591