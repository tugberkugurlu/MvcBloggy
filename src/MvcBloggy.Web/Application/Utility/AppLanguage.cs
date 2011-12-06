using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Application.Utility {

    public class AppLanguage {

        public static string[] GetAll() {

            string[] appLanguages = new[] { "en", "tr" };

            return appLanguages;
        }

        public static string[] GetAllButDefault() {

            return GetAll().Where(x => x != GetDefault()).ToArray();
        }

        public static string[] GetAllBut(string language) {
            return GetAll().Where(x => x != language).ToArray();
        }

        public static string GetDefault() {

            return GetAll().First();
        }

    }
}