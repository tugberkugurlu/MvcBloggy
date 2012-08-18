using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository.EF;
using MvcBloggy.Data.DataAccess.Infrastructure;

namespace MvcBloggy.Data.DataAccess.SqlServer {

    public class UserRepository : Repository<MvcBloggyEntities, User>, IUserRepository {

        public User GetSingle(string userName) {

            return All.FirstOrDefault(x =>
                x.IsApproved == true && x.UserName == userName
            );
        }
    }
}
