using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Model.RequestCommands {
    
    public interface IRequestCommand {

        string Lang { get; set; }
    }
}
