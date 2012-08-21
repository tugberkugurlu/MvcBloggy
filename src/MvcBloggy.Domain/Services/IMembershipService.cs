using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public interface IMembershipService {

        IPrincipal ValidateUser(string username, string password);
        bool CreateUser(string username, string email, string password);
        bool ChangePassword(string username, string oldPassword, string newPassword);
    }
}
