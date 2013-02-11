using MvcBloggy.Domain.Services;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using WebApiDoodle.Web.MessageHandlers;

namespace MvcBloggy.API.MessageHandlers {

    public class MvcBloggyBasicAuthHandler : BasicAuthenticationHandler {

        protected override Task<IPrincipal> AuthenticateUserAsync(
            HttpRequestMessage request, string username, string password, 
            CancellationToken cancellationToken) {

            var membershipService = (IMembershipService)request.GetDependencyScope().GetService(typeof(IMembershipService));
            var principal = membershipService.ValidateUser(username, password);
            return Task.FromResult(principal);
        }
    }
}