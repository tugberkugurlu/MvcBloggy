using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GenericRepository;
using MvcBloggy.Data.DataAccess.SqlServer;

namespace MvcBloggy.Data.DataAccess.Infrastructure {

    public interface IUserRepository : IRepository<User> {

        User GetSingle(string userName, string password);
    }
}