using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    [MetadataType(typeof(Language.MetaData))]
    public partial class Language {

        private class MetaData { 

        }

    }
}