using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Application.Services {

    public class AuthorizationService : IAuthorizationService {

        public void CreateUser(string userName, string password, string email) {
            throw new NotImplementedException();
        }

        public bool Authorize(string userName, string password) {
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