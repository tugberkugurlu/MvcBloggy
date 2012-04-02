using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MvcBloggy.Tests {

    public class DefaultControllerTests {

        [Fact]
        public void pass_you_son_of_a_bitch_fucking_bastard() {

            Assert.Equal(1, 1);
        }

        //home page should list the latest 5 posts
        //the pagination should be implemented
    }
}