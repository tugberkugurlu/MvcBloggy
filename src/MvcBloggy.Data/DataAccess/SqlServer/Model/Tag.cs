using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcBloggy.Data.DataAccess.SqlServer.Model {

    public class Tag {

        public string TagName { get; set; }
        public int Count { get; set; }
    }
}