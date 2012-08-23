using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace MvcBloggy.Web {

    internal static class MediaTypeConstants {

        private static readonly MediaTypeHeaderValue _defaultApplicationXmlMediaType = new MediaTypeHeaderValue("application/xml");
        private static readonly MediaTypeHeaderValue _defaultTextXmlMediaType = new MediaTypeHeaderValue("text/xml");
        private static readonly MediaTypeHeaderValue _defaultApplicationJsonMediaType = new MediaTypeHeaderValue("application/json");
        private static readonly MediaTypeHeaderValue _defaultTextJsonMediaType = new MediaTypeHeaderValue("text/json");
        private static readonly MediaTypeHeaderValue _defaultApplicationOctetStreamMediaType = new MediaTypeHeaderValue("application/octet-stream");
        private static readonly MediaTypeHeaderValue _defaultApplicationFormUrlEncodedMediaType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");

        public static MediaTypeHeaderValue ApplicationOctetStreamMediaType {

            get { return _defaultApplicationOctetStreamMediaType.Clone(); }
        }

        public static MediaTypeHeaderValue ApplicationXmlMediaType {

            get { return _defaultApplicationXmlMediaType.Clone(); }
        }

        public static MediaTypeHeaderValue ApplicationJsonMediaType {

            get { return _defaultApplicationJsonMediaType.Clone(); }
        }

        public static MediaTypeHeaderValue TextXmlMediaType {

            get { return _defaultTextXmlMediaType.Clone(); }
        }

        public static MediaTypeHeaderValue TextJsonMediaType {

            get { return _defaultTextJsonMediaType.Clone(); }
        }

        public static MediaTypeHeaderValue ApplicationFormUrlEncodedMediaType {

            get { return _defaultApplicationFormUrlEncodedMediaType.Clone(); }
        }
    }
}