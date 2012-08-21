using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.Domain.Services {

    public interface ICryptoService {

        string GenerateSalt();
        string EncryptPassword(string password, string salt);
    }
}
