using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestCommands {

    public class ArchiveYearMonthRequestCommand : PaginatedRequestCommand {

        [RegularExpression(@"^\d{4}$")]
        public int Year { get; set; }

        [Range(1, 12)]
        public int Month { get; set; }
    }
}