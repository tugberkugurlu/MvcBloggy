using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    [MetadataType(typeof(BlogPost.MetaData))]
    public partial class BlogPost {

        public virtual ICollection<string> Tags {

            get {
                return TagHelper.CreateStringListFromString(this.BlogPostTags);
            }
        }

        private class MetaData { 

        }
    }
}