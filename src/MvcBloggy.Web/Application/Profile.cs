using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBloggy.Web.Application {

    [Serializable()]
    public class Profile {

        [System.Xml.Serialization.XmlElement("name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement("link")]
        public string Link { get; set; }
    }
}