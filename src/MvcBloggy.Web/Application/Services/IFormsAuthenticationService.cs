using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MvcBloggy.Web.Application.Services {

    public interface IFormsAuthenticationService {

        void SignIn(string userName, bool createPersistentCookie);
        void SignOut();
    }
}