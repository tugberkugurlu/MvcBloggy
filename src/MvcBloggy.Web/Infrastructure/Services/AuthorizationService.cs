using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Infrastructure.Services {

    public class AuthorizationService : IAuthorizationService {

        //private readonly IUserRepository _userRepo;

        //public AuthorizationService(IUserRepository userRepo) {

        //    _userRepo = userRepo;
        //}

        public void CreateUser(string userName, string password, string email) {

            //_userRepo.Add(new Data.DataAccess.SqlServer.User { 
            //    UserName = userName,
            //    Email = email,
            //    Password = getHashedPassword(password),
            //    HashAlgorithm = "SHA512",
            //    IsApproved = true
            //});
            //_userRepo.Save();
        }

        public bool Authorize(string userName, string password) {

            //var user = _userRepo.GetSingle(userName);

            //if (user == null)
            //    return false;

            //return isEqual(password, user.Password);

            throw new NotImplementedException();
        }

        public bool ChangePassword(string userName, string oldPassword, string newPassword) {
            throw new NotImplementedException();
        }

        //private helpers
        private string getHashedPassword(string rawPassword) {

            using (System.Security.Cryptography.SHA512Managed hashTool =
                new System.Security.Cryptography.SHA512Managed()) {

                Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(rawPassword);
                Byte[] EncryptedBytes = hashTool.ComputeHash(PasswordAsByte);
                hashTool.Clear();

                return Convert.ToBase64String(EncryptedBytes);
            }
        }

        private bool isEqual(string rawPassword, string hashedPasword) {

            return string.Equals(
                getHashedPassword(rawPassword), hashedPasword
            );
        }
    }
}