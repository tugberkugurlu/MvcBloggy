using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace MvcBloggy.Web.Application {

    [Serializable()]
    [System.Xml.Serialization.XmlRoot("mvcBloggy")]
    public class MvcBloggy {

        [XmlElement("application", typeof(Application))]
        public Application Application { get; set; }

        [XmlArray("meProfiles")]
        [XmlArrayItem("profile", typeof(Profile))]
        public Profile[] MeProfiles { get; set; }

        [XmlArray("socialProfiles")]
        [XmlArrayItem("profile", typeof(Profile))]
        public Profile[] SocialProfiles { get; set; }
    }
}