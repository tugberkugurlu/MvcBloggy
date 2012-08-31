using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBloggy.API.Infrastructure.Controllers {

    /// <summary>
    /// 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class UriParameterAttribute : Attribute {

        private readonly string[] _paramsArray;

        public UriParameterAttribute(params string[] parameters) {

            _paramsArray = parameters;
        }

        public string[] Parameters {

            get {
                return _paramsArray;
            }
        }
    }
}