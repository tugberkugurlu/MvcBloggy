using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcBloggy.Web.Application {

    [Serializable()]
    public class Application {

        [XmlElement("appName")]
        public string AppName { get; set; }

        [XmlElement("userAlias")]
        public string UserAlias { get; set; }

        [XmlElement("appTitle")]
        public string AppTitle { get; set; }

        [XmlElement("appSlogan")]
        public string AppSlogan { get; set; }
    }
}