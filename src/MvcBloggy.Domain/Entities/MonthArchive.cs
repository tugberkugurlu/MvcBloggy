using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {
    
    public class MonthArchive {

        public int Year { get; set; }
        public int Month { get; set; }
        public int Total { get; set; }
    }
}
