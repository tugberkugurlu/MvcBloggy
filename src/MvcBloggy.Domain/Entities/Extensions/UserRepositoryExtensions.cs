using GenericRepository.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Entities {

    public static class UserRepositoryExtensions {

        public static User GetSingleByUsername(
            this IEntityRepository<User, Guid> userRepository,
            string username) {

                return userRepository.GetAll()
                    .FirstOrDefault(x => x.Name == username);
        }
    }
}
