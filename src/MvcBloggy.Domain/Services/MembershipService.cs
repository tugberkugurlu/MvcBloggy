using MvcBloggy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public class MembershipService : IMembershipService {

        private readonly ICryptoService _cryptoService;
        private readonly IEntityRepository<User> _userRepository;

        public MembershipService(
            ICryptoService cryptoService,
            IEntityRepository<User> userRepository) {

            _cryptoService = cryptoService;
            _userRepository = userRepository;
        }

        public IPrincipal ValidateUser(string username, string password) {

            var user = _userRepository.GetSingleByUsername(username);

            if (user != null && isUserValid(user, password)) {

                var identity = new GenericIdentity(user.Name);
                return new GenericPrincipal(identity, null);
            }

            return null;
        }

        public bool CreateUser(string username, string email, string password) {

            var existingUser = _userRepository.GetAll().Any(
                x => x.Name == username);

            if (!existingUser) {
                return false;
            }

            var passwordSalt = _cryptoService.GenerateSalt();

            var user = new User() {
                Name = username,
                Salt = passwordSalt,
                Email = email,
                IsLocked = false,
                HashedPassword = _cryptoService.EncryptPassword(password, passwordSalt),
                CreatedOn = DateTimeOffset.Now
            };

            _userRepository.Add(user);
            _userRepository.Save();

            return true;
        }

        public bool ChangePassword(string username, string oldPassword, string newPassword) {

            var user = _userRepository.GetSingleByUsername(username);

            if (user != null && isPasswordValid(user, oldPassword)) {

                user.HashedPassword =
                    _cryptoService.EncryptPassword(newPassword, user.Salt);

                _userRepository.Edit(user);
                _userRepository.Save();

                return true;
            }

            return false;
        }

        private bool isUserValid(User user, string password) {

            return isPasswordValid(user, password)
                ? !user.IsLocked
                    ? true
                    : false
                : false;
        }

        private bool isPasswordValid(User user, string password) {

            return string.Equals(
                    _cryptoService.EncryptPassword(
                        password, user.Salt), user.HashedPassword);
        }
    }
}
