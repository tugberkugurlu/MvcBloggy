using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moq;
using MvcBloggy.Data.DataAccess.Infrastructure;
using MvcBloggy.Data.DataAccess.SqlServer;
using MvcBloggy.Web.Application.Services;
using Xunit;

namespace MvcBloggy.Tests.Services {

    public class AuthorizationServiceFacts {

        //auth service should auth the user which has correct pass and email
        //auth service shouldn't auth the user which has correct pass and email
        //auth service should create the user successfully

        //private IUserRepository getUserRepoForCheck() {

        //    //create the mock repo with right credentials
        //    var userRepoMock = new Mock<IUserRepository>();
        //    userRepoMock.Setup(m => m.GetSingle(
        //            It.Is<string>(s => s == "admin")
        //        )
        //    ).Returns<string>(r => new User {
        //        UserId = 1,
        //        UserName = r,
        //        Email = "admin@example.com",
        //        Password = getHashedPassword("password"),
        //        HashAlgorithm = "SHA512",
        //        IsApproved = true,
        //    });

        //    return userRepoMock.Object;
        //}

        //private string getHashedPassword(string rawPassword) {

        //    using (System.Security.Cryptography.SHA512Managed hashTool =
        //        new System.Security.Cryptography.SHA512Managed()) {

        //        Byte[] PasswordAsByte = System.Text.Encoding.UTF8.GetBytes(rawPassword);
        //        Byte[] EncryptedBytes = hashTool.ComputeHash(PasswordAsByte);
        //        hashTool.Clear();

        //        return Convert.ToBase64String(EncryptedBytes);
        //    }
        //}

        //[Fact]
        //public void authservice_should_auth_the_user_with_right_credentials() {

        //    //get the auth service
        //    var authService = new AuthorizationService(
        //        getUserRepoForCheck()
        //    );

        //    //Assert
        //    Assert.Equal<bool>(true, authService.Authorize("admin", "password"));
        //}

        //[Fact]
        //public void authservice_should_not_auth_the_user_with_wrong_credentials() {

        //    //get the auth service
        //    var authService = new AuthorizationService(
        //        getUserRepoForCheck()
        //    );

        //    //Assert
        //    Assert.Equal<bool>(false, authService.Authorize("foobar", "foopassword"));
        //}

        //[Fact]
        //public void authservice_should_not_auth_the_user_with_right_username_wrong_password() {

        //    //get the auth service
        //    var authService = new AuthorizationService(
        //        getUserRepoForCheck()
        //    );

        //    //Assert
        //    Assert.Equal<bool>(false, authService.Authorize("admin", "foopassword"));
        //}

        //[Fact]
        //public void authservice_should_create_the_user() {

        //}
    }
}