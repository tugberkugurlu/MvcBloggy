using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Application.Services {
    
    public interface IApplicationSettings {

        string BlogApiBaseAddress { get; }

        string BlogApiUserName { get; }
        string BlogApiPassword { get; }
    }
}