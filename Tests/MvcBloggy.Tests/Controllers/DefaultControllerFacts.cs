using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using GenericRepository;
using Moq;
using MvcBloggy.Web.Controllers;
using Xunit;
using MvcBloggy.Web.Infrastructure.Services;
using MvcBloggy.API.Client.Http;
using MvcBloggy.API.Model.Dtos;

namespace MvcBloggy.Tests.Controllers {

    public class DefaultControllerFacts {

        //home page (DefaultController Index method) should list the latest 5 posts
        //the pagination should be implemented on home page with only next and previous

        [Fact]
        public void default_controller_index_method_should_return_an_instance_of_viewresult() {

            var blogHttpClient = new Mock<IHttpApiClient<BlogPostDto, Guid>>();
            DefaultController controller = new DefaultController(blogHttpClient.Object);

            var result = controller.Index("en");
            
            Assert.IsType<ViewResult>(result);
        }
    }
}