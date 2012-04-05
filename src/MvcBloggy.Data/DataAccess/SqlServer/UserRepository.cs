using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class UserRepository : Repository<MvcBloggyContext, User>, IUserRepository {

        public User GetSingle(string userName, string password) {

            return All.FirstOrDefault(x =>
                x.IsApproved == true && x.UserName == userName && x.Password == password
            );
        }
    }
}
