using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcBloggy.Data.DataAccess.SqlServer.Model {

    public class BlogPostTag {

        public string Tag { get; set; }
        public int Count { get; set; }
    }
}