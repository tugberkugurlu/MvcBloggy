using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    [MetadataType(typeof(RestrictedPageName.MetaData))]
    public partial class RestrictedPageName {

        private class MetaData { 

        }

    }
}
