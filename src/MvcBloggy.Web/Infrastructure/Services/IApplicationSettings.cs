using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Services {
    
    public interface IApplicationSettings {

        string BlogApiBaseAddress { get; }

        string BlogApiUserName { get; }
        string BlogApiPassword { get; }
    }
}