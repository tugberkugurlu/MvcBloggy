using MvcBloggy.Domain.Entities;
using MvcBloggy.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebAPIDoodle.Http;

namespace MvcBloggy.API.MessageHandlers {

    public class MvcBloggyBasicAuthHandler : BasicAuthenticationHandler {

        protected override IPrincipal AuthenticateUser(HttpRequestMessage request, string username, string password, CancellationToken cancellationToken) {

            var membershipService = (IMembershipService)request.GetDependencyScope().GetService(typeof(IMembershipService));
            return membershipService.ValidateUser(username, password);
        }
    }
}