using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MvcBloggy.Web.Application.Services {

    public class FormsAuthTokenStore : ITokenHandler {

        public void SetClientAccess(string token) {
            FormsAuthentication.SetAuthCookie(token, true);
        }

        public void RemoveClientAccess() {
            FormsAuthentication.SignOut();
        }

        public string GetToken() {

            return
                FormsAuthentication.Decrypt(
                    HttpContext.Current.Response.Cookies[FormsAuthentication.FormsCookieName].ToString()
                    ).ToString();
        }
    }
}