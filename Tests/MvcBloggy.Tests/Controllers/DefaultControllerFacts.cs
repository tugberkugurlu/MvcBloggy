using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using GenericRepository;
using Moq;
using MvcBloggy.Data.DataAccess.Infrastructure;
using MvcBloggy.Data.DataAccess.SqlServer;
using MvcBloggy.Web.Controllers;
using Xunit;

namespace MvcBloggy.Controllers.Tests {

    public class DefaultControllerFacts {

        //home page (DefaultController Index method) should list the latest 5 posts
        //the pagination should be implemented on home page with only next and previous

        private IBlogPostRepository getBlogPostRepo() {

            var blogPostRepoMock = new Mock<IBlogPostRepository>();

            return blogPostRepoMock.Object;
        }

        [Fact]
        public void default_controller_index_method_should_return_an_instance_of_viewresult() {

            DefaultController controller = new DefaultController(getBlogPostRepo());

            var result = controller.Index("en");
            
            Assert.IsType<ViewResult>(result);
        }
    }
}