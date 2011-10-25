using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    [MetadataType(typeof(DynamicPage.MetaData))]
    public partial class DynamicPage {

        private class MetaData { 

        }

    }
}