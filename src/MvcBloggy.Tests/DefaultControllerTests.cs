using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using GenericRepository;
using MvcBloggy.Data.DataAccess.Infrastructure;
using MvcBloggy.Data.DataAccess.SqlServer;
using MvcBloggy.Web.Controllers;
using Xunit;

namespace MvcBloggy.Tests {

    public class DefaultControllerTests {

        //home page (DefaultController Index method) should list the latest 5 posts
        //the pagination should be implemented on home page with only next and previous

        [Fact]
        public void default_controller_index_method_should_return_an_instance_of_viewresult() {

            DefaultController controller = new DefaultController();

            var result = controller.Index();
            
            Assert.IsType<ViewResult>(result);
        }
    }
}