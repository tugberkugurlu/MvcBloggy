using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvcBloggy.Web.Infrastructure.Utility;
using Xunit;

namespace MvcBloggy.Tests.Utilities {

    public class SanitizeHTMLExtensionFacts {

        [Fact]
        public void ToSafeHtml_should_allow_p_element() {

            var html = "Lorem Ipsum. <p>Lorem</p> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }


        [Fact]
        public void ToSafeHtml_should_allow_acronym_element() {

            var html = "Lorem Ipsum. <acronym>Lorem</acronym> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_abbr_element() {

            var html = "Lorem Ipsum. <abbr>Lorem</abbr> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_img_element() {

            //actually, this shouldn't be allowed but no problem for now
            var html = "Lorem Ipsum. <img>Lorem</img> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_img_element_with_src_attribute() {

            //actually, this shouldn't be allowed but no problem for now
            var html = "Lorem Ipsum. <img src=\"http://example.com/foo.jpg\">Lorem</img> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_img_element_with_src_and_alt_attribute() {

            var html = "Lorem Ipsum. <img alt=\"foo bar\" src=\"http://example.com/foo.jpg\">Lorem</img> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_img_element_with_src_and_width_attribute() {

            var html = "Lorem Ipsum. <img width=\"300\" src=\"http://example.com/foo.jpg\">Lorem</img> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_img_element_with_src_and_height_attribute() {

            var html = "Lorem Ipsum. <img height=\"300\" src=\"http://example.com/foo.jpg\">Lorem</img> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_blockquote_element() {

            var html = "Lorem Ipsum. <blockquote>Lorem</blockquote> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_blockquote_element_with_cite_attribute() {

            var html = "Lorem Ipsum. <blockquote cite=\"foo bar\">Lorem</blockquote> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_br_element() {

            var html = "Lorem Ipsum. <br/> Lorem. <br/> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_strong_element() {

            var html = "Lorem Ipsum. <strong>Lorem.</strong> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_em_element() {

            var html = "Lorem Ipsum. <em>Lorem.</em> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_u_element() {

            var html = "Lorem Ipsum. <u>Lorem.</u> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_strike_element() {

            var html = "Lorem Ipsum. <strike>Lorem.</strike> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_a_element_and_append_rel_nofollow() {

            var html = "Lorem Ipsum. <a>Lorem.</a> Lorem Ipsum.";
            var expected = "Lorem Ipsum. <a rel=\"nofollow\">Lorem.</a> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Console.WriteLine(output);

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_not_allow_a_element_with_rel_attribute_and_append_rel_nofollow() {

            var html = "Lorem Ipsum. <a rel=\"foo\">Lorem.</a> Lorem Ipsum.";
            var expected = "Lorem Ipsum. <a rel=\"nofollow\">Lorem.</a> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Console.WriteLine(output);

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_a_element_with_href_and_append_rel_nofollow() {

            var html = "Lorem Ipsum. <a href=\"http://example.com\">Lorem.</a> Lorem Ipsum.";
            var expected = "Lorem Ipsum. <a href=\"http://example.com\" rel=\"nofollow\">Lorem.</a> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Console.WriteLine(output);

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_ol_element() {

            //actually, this shouldn't be allowed but no problem for now
            var html = "Lorem Ipsum. <ol>Lorem.</ol> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_ol_element_with_li_element() {

            var html = "Lorem Ipsum. <ol><li>Lorem</li><li>Ipsum</li></ol> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_ul_element() {

            //actually, this shouldn't be allowed but no problem for now
            var html = "Lorem Ipsum. <ul>Lorem.</ul> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_allow_ul_element_with_li_element() {

            var html = "Lorem Ipsum. <ul><li>Lorem</li><li>Ipsum</li></ul> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(html, output);
        }

        [Fact]
        public void ToSafeHtml_should_not_allow_script_element() {

            var html = "Lorem Ipsum. <script>alert('Boom!');</script> Lorem Ipsum.";
            var expected = "Lorem Ipsum. alert('Boom!'); Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_not_allow_div_element() {

            var html = "Lorem Ipsum. <div>foo.</div> Lorem Ipsum.";
            var expected = "Lorem Ipsum. foo. Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_not_allow_a_element_with_any_of_its_attributes_except_for_href_and_append_rel_nofollow() {

            var html = "Lorem Ipsum. <a href=\"http://example.com\" title=\"foo bar\">Lorem.</a> Lorem Ipsum.";
            var expected = "Lorem Ipsum. <a href=\"http://example.com\" rel=\"nofollow\">Lorem.</a> Lorem Ipsum.";

            var output = html.ToSafeHtml();

            Console.WriteLine(output);

            Assert.Equal<string>(expected, output);
        }

        [Fact]
        public void ToSafeHtml_should_not_allow_script_element_but_should_allow_a_and_append_rel_nofollow() {

            var html = "Lorem Ipsum. <script>alert('Boom!');</script> Lorem Ipsum. <a href=\"http://example.com\">example.com</a>";
            var expected = "Lorem Ipsum. alert('Boom!'); Lorem Ipsum. <a href=\"http://example.com\" rel=\"nofollow\">example.com</a>";

            var output = html.ToSafeHtml();

            Assert.Equal<string>(expected, output);
        }
    }
}
