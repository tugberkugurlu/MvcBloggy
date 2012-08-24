using System;
using System.Configuration;

namespace MvcBloggy.Web.Infrastructure.Services {
    
    public class ApplicationSettings : IApplicationSettings {

        public string BlogApiBaseAddress {
            get {
                return ConfigurationManager.AppSettings["blogApi:BaseAddress"];
            }
        }

        public string BlogApiUserName {
            get {
                return ConfigurationManager.AppSettings["blogApi:UserName"];
            }
        }

        public string BlogApiPassword {
            get {
                return ConfigurationManager.AppSettings["blogApi:Password"];
            }
        }
    }
}