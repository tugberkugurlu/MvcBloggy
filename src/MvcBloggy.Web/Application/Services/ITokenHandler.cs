using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcBloggy.Web.Application.Services {

    public interface ITokenHandler {
        
        void SetClientAccess(string token);
        void RemoveClientAccess();
        string GetToken();
    }
}
