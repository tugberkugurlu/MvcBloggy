using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestCommands {
    
    public class RequestCommand : IRequestCommand {

        [Required]
        public string Lang { get; set; }
    }
}
