using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcBloggy.Web.Infrastructure.Utility {

    public class AppSettings {

        public static MvcBloggy MvcBloggy {

            get {

                MvcBloggy _mvcBloggy = null;
                string xmlPath = System.Web.HttpContext.Current.Server.MapPath("~/App_Data/MvcBloggy.me.xml");

                XmlSerializer serializer = new XmlSerializer(typeof(MvcBloggy));

                using (StreamReader reader = new StreamReader(xmlPath)) {
                    _mvcBloggy = (MvcBloggy)serializer.Deserialize(reader);
                    reader.Close();
                }

                return _mvcBloggy;
            }
        }

    }
}